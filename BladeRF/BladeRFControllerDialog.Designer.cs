namespace SDRSharp.BladeRF
{
    partial class BladeRFControllerDialog
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
            this.components = new System.ComponentModel.Container();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gainTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.samplerateComboBox = new System.Windows.Forms.ComboBox();
            this.gainLabel = new System.Windows.Forms.Label();
            this.bladeRFTypeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.samplingModeComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fpgaOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fpgaTextBox = new System.Windows.Forms.TextBox();
            this.fpgaButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.xb200Checkbox = new System.Windows.Forms.CheckBox();
            this.xb200FilterCombobox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bandwidthComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.agcMode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gainTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 1000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(274, 726);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(112, 35);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(18, 40);
            this.deviceComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(368, 28);
            this.deviceComboBox.TabIndex = 0;
            this.deviceComboBox.SelectedIndexChanged += new System.EventHandler(this.deviceComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Device";
            // 
            // gainTrackBar
            // 
            this.gainTrackBar.LargeChange = 3;
            this.gainTrackBar.Location = new System.Drawing.Point(21, 47);
            this.gainTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gainTrackBar.Maximum = 70;
            this.gainTrackBar.Name = "gainTrackBar";
            this.gainTrackBar.Size = new System.Drawing.Size(324, 69);
            this.gainTrackBar.SmallChange = 3;
            this.gainTrackBar.TabIndex = 6;
            this.gainTrackBar.Value = 20;
            this.gainTrackBar.Scroll += new System.EventHandler(this.rxVga2GainTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sample Rate";
            // 
            // samplerateComboBox
            // 
            this.samplerateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.samplerateComboBox.FormattingEnabled = true;
            this.samplerateComboBox.Location = new System.Drawing.Point(18, 191);
            this.samplerateComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.samplerateComboBox.Name = "samplerateComboBox";
            this.samplerateComboBox.Size = new System.Drawing.Size(152, 28);
            this.samplerateComboBox.TabIndex = 1;
            this.samplerateComboBox.SelectedIndexChanged += new System.EventHandler(this.samplerateComboBox_SelectedIndexChanged);
            // 
            // gainLabel
            // 
            this.gainLabel.Location = new System.Drawing.Point(243, 25);
            this.gainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gainLabel.Name = "gainLabel";
            this.gainLabel.Size = new System.Drawing.Size(102, 20);
            this.gainLabel.TabIndex = 26;
            this.gainLabel.Text = "0dB";
            this.gainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bladeRFTypeLabel
            // 
            this.bladeRFTypeLabel.Location = new System.Drawing.Point(112, 14);
            this.bladeRFTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bladeRFTypeLabel.Name = "bladeRFTypeLabel";
            this.bladeRFTypeLabel.Size = new System.Drawing.Size(276, 20);
            this.bladeRFTypeLabel.TabIndex = 29;
            this.bladeRFTypeLabel.Text = "BladeRF";
            this.bladeRFTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Sampling Mode";
            // 
            // samplingModeComboBox
            // 
            this.samplingModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.samplingModeComboBox.FormattingEnabled = true;
            this.samplingModeComboBox.Items.AddRange(new object[] {
            "Unknown",
            "RX/TX SMA",
            "J60/J61 connectors"});
            this.samplingModeComboBox.Location = new System.Drawing.Point(18, 114);
            this.samplingModeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.samplingModeComboBox.Name = "samplingModeComboBox";
            this.samplingModeComboBox.Size = new System.Drawing.Size(368, 28);
            this.samplingModeComboBox.TabIndex = 2;
            this.samplingModeComboBox.SelectedIndexChanged += new System.EventHandler(this.samplingModeComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "System Gain";
            // 
            // fpgaOpenFileDialog
            // 
            this.fpgaOpenFileDialog.AddExtension = false;
            this.fpgaOpenFileDialog.FileName = "openFileDialog1";
            this.fpgaOpenFileDialog.Filter = "rbf files|*.rbf";
            this.fpgaOpenFileDialog.ReadOnlyChecked = true;
            this.fpgaOpenFileDialog.Title = "Choose FPGA file";
            // 
            // fpgaTextBox
            // 
            this.fpgaTextBox.Location = new System.Drawing.Point(16, 663);
            this.fpgaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fpgaTextBox.Name = "fpgaTextBox";
            this.fpgaTextBox.ReadOnly = true;
            this.fpgaTextBox.Size = new System.Drawing.Size(238, 26);
            this.fpgaTextBox.TabIndex = 38;
            // 
            // fpgaButton
            // 
            this.fpgaButton.Location = new System.Drawing.Point(274, 660);
            this.fpgaButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fpgaButton.Name = "fpgaButton";
            this.fpgaButton.Size = new System.Drawing.Size(112, 35);
            this.fpgaButton.TabIndex = 39;
            this.fpgaButton.Text = "Browse...";
            this.fpgaButton.UseVisualStyleBackColor = true;
            this.fpgaButton.Click += new System.EventHandler(this.fpgaButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 631);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "FPGA File";
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(12, 726);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(252, 35);
            this.labelVersion.TabIndex = 41;
            // 
            // xb200Checkbox
            // 
            this.xb200Checkbox.AutoSize = true;
            this.xb200Checkbox.Location = new System.Drawing.Point(9, 35);
            this.xb200Checkbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xb200Checkbox.Name = "xb200Checkbox";
            this.xb200Checkbox.Size = new System.Drawing.Size(272, 24);
            this.xb200Checkbox.TabIndex = 42;
            this.xb200Checkbox.Text = "Enable XB-200 Transverter board";
            this.xb200Checkbox.UseVisualStyleBackColor = true;
            this.xb200Checkbox.CheckedChanged += new System.EventHandler(this.xb200Checkbox_CheckedChanged);
            // 
            // xb200FilterCombobox
            // 
            this.xb200FilterCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xb200FilterCombobox.Enabled = false;
            this.xb200FilterCombobox.FormattingEnabled = true;
            this.xb200FilterCombobox.Location = new System.Drawing.Point(9, 98);
            this.xb200FilterCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xb200FilterCombobox.Name = "xb200FilterCombobox";
            this.xb200FilterCombobox.Size = new System.Drawing.Size(350, 28);
            this.xb200FilterCombobox.TabIndex = 43;
            this.xb200FilterCombobox.SelectedIndexChanged += new System.EventHandler(this.xb200FilterCombobox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.xb200Checkbox);
            this.groupBox1.Controls.Add(this.xb200FilterCombobox);
            this.groupBox1.Location = new System.Drawing.Point(18, 465);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(370, 154);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XB-200 configuration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Filter bank";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 165);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Bandwidth";
            // 
            // bandwidthComboBox
            // 
            this.bandwidthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bandwidthComboBox.FormattingEnabled = true;
            this.bandwidthComboBox.Location = new System.Drawing.Point(201, 191);
            this.bandwidthComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bandwidthComboBox.Name = "bandwidthComboBox";
            this.bandwidthComboBox.Size = new System.Drawing.Size(186, 28);
            this.bandwidthComboBox.TabIndex = 45;
            this.bandwidthComboBox.SelectedIndexChanged += new System.EventHandler(this.bandwidthComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.gainLabel);
            this.groupBox2.Controls.Add(this.gainTrackBar);
            this.groupBox2.Location = new System.Drawing.Point(18, 312);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(370, 126);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gain controls";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 234);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "Automatic Gain Control";
            // 
            // agcMode
            // 
            this.agcMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agcMode.FormattingEnabled = true;
            this.agcMode.Items.AddRange(new object[] {
            "Automatic",
            "Manual",
            "Fast",
            "Slow"});
            this.agcMode.Location = new System.Drawing.Point(18, 260);
            this.agcMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.agcMode.Name = "agcMode";
            this.agcMode.Size = new System.Drawing.Size(368, 28);
            this.agcMode.TabIndex = 48;
            this.agcMode.SelectedIndexChanged += new System.EventHandler(this.agcMode_SelectedIndexChanged);
            // 
            // BladeRFControllerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(408, 796);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.agcMode);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bandwidthComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fpgaButton);
            this.Controls.Add(this.fpgaTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.samplingModeComboBox);
            this.Controls.Add(this.bladeRFTypeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.samplerateComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deviceComboBox);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BladeRFControllerDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BladeRF Controller";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BladeRFControllerDialog_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.BladeRFControllerDialog_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gainTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar gainTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox samplerateComboBox;
        private System.Windows.Forms.Label gainLabel;
        private System.Windows.Forms.Label bladeRFTypeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox samplingModeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog fpgaOpenFileDialog;
        private System.Windows.Forms.TextBox fpgaTextBox;
        private System.Windows.Forms.Button fpgaButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.CheckBox xb200Checkbox;
        private System.Windows.Forms.ComboBox xb200FilterCombobox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox bandwidthComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox agcMode;
    }
}

