using System.ComponentModel;
using SCHOTT.WinForms;

namespace SCHOTT.CVLS.Programmer
{
    public class ApplicationSettings
    {
        public BindingList<ProgrammingOption> ProgrammingOptions = new BindingList<ProgrammingOption>();
        public WindowInformation FormSettings = new WindowInformation();

        public ApplicationSettings()
        {
            SetDefaultValues();
        }

        public void SetDefaultValues()
        {
            ProgrammingOptions.Clear();
            ProgrammingOptions.Add(new ProgrammingOption { Name = "Restore Factory Defaults", Commands = "&o;" });
            ProgrammingOptions.Add(new ProgrammingOption { Name = "DCR III Remote Emulator", Commands = "&o;&l1;&hl0;&m1;&s;", MinimumFirmware = "1.14" });
            ProgrammingOptions.Add(new ProgrammingOption { Name = "LED Output On At Powerup", Commands = "&o;&l1;&m0;&s;", MinimumFirmware = "1.14" });
        }
    }

    public class ProgrammingOption
    {
        public string Name { get; set; }
        public string Commands { get; set; }
        public string MinimumFirmware { get; set; }
    }
}
