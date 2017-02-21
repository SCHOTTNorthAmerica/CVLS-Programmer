using SCHOTT.WinForms.Controls.TextBoxes;

namespace SCHOTT.CVLS.Programmer
{
    /// <summary>
    /// The main form of the default settings programmer.
    /// </summary>
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.removeMode = new System.Windows.Forms.Button();
            this.mode = new System.Windows.Forms.ListBox();
            this.resetDefaults = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.minimumFirmware = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.modeName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.commands = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.addMode = new System.Windows.Forms.Button();
            this.program = new System.Windows.Forms.Button();
            this.startAuto = new System.Windows.Forms.Button();
            this.stopAuto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.MessageBox = new SCHOTT.WinForms.Controls.TextBoxes.AdvancedRichTextBox();
            this.clearStatus = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programming Mode";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.removeMode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resetDefaults, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(208, 331);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // removeMode
            // 
            this.removeMode.AutoSize = true;
            this.removeMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeMode.Location = new System.Drawing.Point(3, 276);
            this.removeMode.Name = "removeMode";
            this.removeMode.Size = new System.Drawing.Size(202, 23);
            this.removeMode.TabIndex = 0;
            this.removeMode.Text = "Remove Selected Mode";
            this.removeMode.UseVisualStyleBackColor = true;
            this.removeMode.Click += new System.EventHandler(this.removeMode_Click);
            // 
            // mode
            // 
            this.mode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mode.FormattingEnabled = true;
            this.mode.Location = new System.Drawing.Point(3, 3);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(202, 267);
            this.mode.TabIndex = 1;
            this.mode.SelectedValueChanged += new System.EventHandler(this.mode_SelectedValueChanged);
            // 
            // resetDefaults
            // 
            this.resetDefaults.AutoSize = true;
            this.resetDefaults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetDefaults.Dock = System.Windows.Forms.DockStyle.Top;
            this.resetDefaults.Location = new System.Drawing.Point(3, 305);
            this.resetDefaults.Name = "resetDefaults";
            this.resetDefaults.Size = new System.Drawing.Size(202, 23);
            this.resetDefaults.TabIndex = 2;
            this.resetDefaults.Text = "Restore Default Modes";
            this.resetDefaults.UseVisualStyleBackColor = true;
            this.resetDefaults.Click += new System.EventHandler(this.resetDefaults_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(226, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 350);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode Options";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(466, 331);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.minimumFirmware, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 67);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(460, 27);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Minimum Firmware";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimumFirmware
            // 
            this.minimumFirmware.Dock = System.Windows.Forms.DockStyle.Top;
            this.minimumFirmware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minimumFirmware.FormattingEnabled = true;
            this.minimumFirmware.Location = new System.Drawing.Point(106, 3);
            this.minimumFirmware.Name = "minimumFirmware";
            this.minimumFirmware.Size = new System.Drawing.Size(351, 21);
            this.minimumFirmware.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.modeName, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(460, 26);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mode Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modeName
            // 
            this.modeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.modeName.Location = new System.Drawing.Point(78, 3);
            this.modeName.Name = "modeName";
            this.modeName.Size = new System.Drawing.Size(379, 20);
            this.modeName.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.commands, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(460, 26);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mode Commands";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commands
            // 
            this.commands.Dock = System.Windows.Forms.DockStyle.Top;
            this.commands.Location = new System.Drawing.Point(102, 3);
            this.commands.Name = "commands";
            this.commands.Size = new System.Drawing.Size(355, 20);
            this.commands.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 9;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.addMode, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.program, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.startAuto, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.stopAuto, 7, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 100);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(460, 29);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // addMode
            // 
            this.addMode.AutoSize = true;
            this.addMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.addMode.Location = new System.Drawing.Point(15, 3);
            this.addMode.Name = "addMode";
            this.addMode.Size = new System.Drawing.Size(106, 23);
            this.addMode.TabIndex = 0;
            this.addMode.Text = "Add/Update Mode";
            this.addMode.UseVisualStyleBackColor = true;
            this.addMode.Click += new System.EventHandler(this.addMode_Click);
            // 
            // program
            // 
            this.program.AutoSize = true;
            this.program.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.program.Dock = System.Windows.Forms.DockStyle.Top;
            this.program.Location = new System.Drawing.Point(139, 3);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(81, 23);
            this.program.TabIndex = 0;
            this.program.Text = "Program Now";
            this.program.UseVisualStyleBackColor = true;
            this.program.Click += new System.EventHandler(this.program_Click);
            // 
            // startAuto
            // 
            this.startAuto.AutoSize = true;
            this.startAuto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startAuto.Dock = System.Windows.Forms.DockStyle.Top;
            this.startAuto.Location = new System.Drawing.Point(238, 3);
            this.startAuto.Name = "startAuto";
            this.startAuto.Size = new System.Drawing.Size(94, 23);
            this.startAuto.TabIndex = 0;
            this.startAuto.Text = "Start Auto Mode";
            this.startAuto.UseVisualStyleBackColor = true;
            this.startAuto.Click += new System.EventHandler(this.startAuto_Click);
            // 
            // stopAuto
            // 
            this.stopAuto.AutoSize = true;
            this.stopAuto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stopAuto.Dock = System.Windows.Forms.DockStyle.Top;
            this.stopAuto.Enabled = false;
            this.stopAuto.Location = new System.Drawing.Point(350, 3);
            this.stopAuto.Name = "stopAuto";
            this.stopAuto.Size = new System.Drawing.Size(94, 23);
            this.stopAuto.TabIndex = 0;
            this.stopAuto.Text = "Stop Auto Mode";
            this.stopAuto.UseVisualStyleBackColor = true;
            this.stopAuto.Click += new System.EventHandler(this.stopAuto_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel7);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 193);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status Readout";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.MessageBox, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.clearStatus, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(454, 174);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // MessageBox
            // 
            this.MessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageBox.Location = new System.Drawing.Point(3, 3);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(448, 139);
            this.MessageBox.TabIndex = 0;
            this.MessageBox.Text = "";
            // 
            // clearStatus
            // 
            this.clearStatus.AutoSize = true;
            this.clearStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.clearStatus.Location = new System.Drawing.Point(3, 148);
            this.clearStatus.Name = "clearStatus";
            this.clearStatus.Size = new System.Drawing.Size(448, 23);
            this.clearStatus.TabIndex = 1;
            this.clearStatus.Text = "Clear";
            this.clearStatus.UseVisualStyleBackColor = true;
            this.clearStatus.Click += new System.EventHandler(this.clearStatus_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(704, 362);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 362);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(720, 400);
            this.Name = "MainForm";
            this.Text = "CV-LS Programmer";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button removeMode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modeName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox commands;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button addMode;
        private System.Windows.Forms.ComboBox minimumFirmware;
        private System.Windows.Forms.Button program;
        private System.Windows.Forms.Button startAuto;
        private System.Windows.Forms.Button stopAuto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private AdvancedRichTextBox MessageBox;
        private System.Windows.Forms.Button clearStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.ListBox mode;
        private System.Windows.Forms.Button resetDefaults;
    }
}

