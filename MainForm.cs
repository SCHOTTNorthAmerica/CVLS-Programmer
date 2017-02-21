using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using SCHOTT.Core.Communication.Serial;
using SCHOTT.Core.Extensions;
using SCHOTT.Core.Settings;
using SCHOTT.Core.Threading;
using SCHOTT.Core.Utilities;
using SCHOTT.CVLS.Serial;
using SCHOTT.WinForms.Dialogs;

namespace SCHOTT.CVLS.Programmer
{
    public partial class MainForm : Form
    {
        private readonly ApplicationSettings _applicationSettings = new ApplicationSettings();
        private readonly ClosingWorker _closingWorker;
        private readonly CVLSThreadedComPort _cvlsThreadedComPort;

        public MainForm()
        {
            InitializeComponent();
            AppendVersionToFormTitle();
            _applicationSettings.ReadSettings();

            // this allows dialogs to be called from the DLLs
            CrossThreadDialogs.InitializeDialogs(this);

            // establish the closing worker
            _closingWorker = new ClosingWorker();

            // start child threads
            _cvlsThreadedComPort = new CVLSThreadedComPort("Com Port", _closingWorker, CVLSPortType.Usb);
            _cvlsThreadedComPort.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, ComPortConnectionUpdate);

            // initialize form state
            InitializeFormState();

            // subscribe to form closing
            FormClosing += MainForm_FormClosing;
        }

        private void AppendVersionToFormTitle()
        {
            Text += $@" V{Assembly.GetEntryAssembly().GetName().Version.Major}.{Assembly.GetEntryAssembly().GetName().Version.Minor}";
        }
        
        private void InitializeFormState()
        {
            minimumFirmware.Items.Clear();
            var firmwareVersions = CustomerFirmware.Streams.Keys.ToList();
            firmwareVersions.Sort();
            firmwareVersions.ForEach(s=>minimumFirmware.Items.Add(s));

            ComPortConnectionUpdate(_cvlsThreadedComPort.GetCurrentConnectionUpdate());
            AutoMode(false);
            mode.DataSource = _applicationSettings.ProgrammingOptions;
            mode.DisplayMember = "Name";
        }

        private void ComPortConnectionUpdate(ThreadedComPortBase.ConnectionUpdateArgs args)
        {
            program.Enabled = args.IsConnected;
            
            if(args.IsConnected)
            {
                var serial = int.Parse(_cvlsThreadedComPort.SendCommandSingle("&z", true));
                MessageBox.WriteLine($"Connected to Serial ({serial}) on ({args.Port})");

                if (stopAuto.Enabled)
                {
                    ProgramUnit();
                }
            }
            else if (args.Port == null)
            {
                if (MessageBox.Text.Length <= 0)
                    return;

                MessageBox.WriteLine("Disconnected from Unit");
                MessageBox.WriteLine();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // save current settings
            _applicationSettings.WriteSettings();
            _closingWorker.WaitForThreadsToCloseDialogOutput();
        }
        
        private void AutoMode(bool enabled)
        {
            stopAuto.Enabled = enabled;
            startAuto.Enabled = !enabled;
            modeName.Enabled = !enabled;
            commands.Enabled = !enabled;
            mode.Enabled = !enabled;
            removeMode.Enabled = !enabled;
            addMode.Enabled = !enabled;
            minimumFirmware.Enabled = !enabled;
        }

        private void startAuto_Click(object sender, EventArgs e)
        {
            AutoMode(true);
        }

        private void stopAuto_Click(object sender, EventArgs e)
        {
            AutoMode(false);
        }

        private void removeMode_Click(object sender, EventArgs e)
        {
            _applicationSettings.ProgrammingOptions.Remove((ProgrammingOption)mode.SelectedValue);
        }

        private void mode_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateFields();
        }

        private void UpdateFields()
        {
            if ((ProgrammingOption)mode.SelectedValue == null)
            {
                modeName.Text = "";
                commands.Text = "";
                minimumFirmware.SelectedIndex = 0;
                return;
            }

            modeName.Text = ((ProgrammingOption)mode.SelectedValue).Name;
            commands.Text = ((ProgrammingOption)mode.SelectedValue).Commands;

            var firmware = ((ProgrammingOption)mode.SelectedValue).MinimumFirmware ?? 
                minimumFirmware.Items[0].ToString();

            if (minimumFirmware.Items.Contains(firmware))
            {
                minimumFirmware.Text = firmware;
            }
            else
            {
                minimumFirmware.SelectedIndex = 0;
            }
        }

        private void resetDefaults_Click(object sender, EventArgs e)
        {
            _applicationSettings.SetDefaultValues();
            UpdateFields();
        }

        private void addMode_Click(object sender, EventArgs e)
        {
            if (modeName.Text.Length == 0)
            {
                CrossThreadDialogs.MessageBoxBlocking(new DialogConfiguration
                {
                    Message = "You must enter a Mode Name!",
                    Title = "Mode Error!"
                });
                return;
            }

            var modesList = _applicationSettings.ProgrammingOptions.Where(o => o.Name == modeName.Text).ToList();
            switch (modesList.Count)
            {
                case 0:
                    // add a new mode
                    var newMode = new ProgrammingOption
                    {
                        Name = modeName.Text,
                        Commands = commands.Text,
                        MinimumFirmware = minimumFirmware.Text
                    };
                    _applicationSettings.ProgrammingOptions.Add(newMode);
                    mode.SelectedItem = newMode;
                    break;

                case 1:
                    // update existing mode
                    modesList.First().Commands = commands.Text;
                    modesList.First().MinimumFirmware = minimumFirmware.Text;
                    break;

                default:
                    CrossThreadDialogs.MessageBoxBlocking(new DialogConfiguration
                    {
                        Message = $"There are {modesList.Count} Modes already with that name.",
                        Title = "Mode Error!"
                    });
                    return;
            }

        }

        private void program_Click(object sender, EventArgs e)
        {
            ProgramUnit();
        }

        private void ProgramUnit()
        {
            if (!_cvlsThreadedComPort.IsConnected)
                return;

            try
            {
                var tokens = _cvlsThreadedComPort.SendCommandSingle("&f", true).Split(' ');
                var firmware = double.Parse(tokens[0]);

                if (firmware >= double.Parse(minimumFirmware.Text))
                {
                    var commandArray = commands.Text.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var s in commandArray)
                    {
                        MessageBox.WriteLine($"Sending Command ({s}) => Responce ({_cvlsThreadedComPort.SendCommandSingle(s)})");
                    }
                    MessageBox.WriteLine("Programming Complete");
                }
                else
                {
                    MessageBox.WriteLine($"Unit Firmware (V{firmware}) does not meet the minimum requirement (V{minimumFirmware.Text})!", true, Color.Red);
                    MessageBox.WriteLine("Cannot Program Unit!", true, Color.Red);
                }
            }
            catch
            {
                // ignored
            }
        }

        private void clearStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Clear();
        }
    }
}
