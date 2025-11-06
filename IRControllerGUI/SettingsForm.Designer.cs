namespace IRControllerGUI
{
    partial class SettingsForm
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
            SettingsLayout = new TableLayoutPanel();
            EQToolPathTextBox = new TextBox();
            GameLauncherPathTextBox = new TextBox();
            BaudRateSettingLabel = new Label();
            GameLauncherSettingLabel = new Label();
            EQToolSettingLabel = new Label();
            USBScanToolSettingLabel = new Label();
            SaveSettingsButton = new Button();
            ComPortSettingLabel = new Label();
            SettingsLabel = new Label();
            COMPortComboBox = new ComboBox();
            BaudRateTextBox = new TextBox();
            USBScanToolPathTextBox = new TextBox();
            SettingsLayout.SuspendLayout();
            SuspendLayout();
            // 
            // SettingsLayout
            // 
            SettingsLayout.ColumnCount = 2;
            SettingsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SettingsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SettingsLayout.Controls.Add(EQToolPathTextBox, 1, 4);
            SettingsLayout.Controls.Add(GameLauncherPathTextBox, 1, 3);
            SettingsLayout.Controls.Add(BaudRateSettingLabel, 0, 2);
            SettingsLayout.Controls.Add(GameLauncherSettingLabel, 0, 3);
            SettingsLayout.Controls.Add(EQToolSettingLabel, 0, 4);
            SettingsLayout.Controls.Add(USBScanToolSettingLabel, 0, 5);
            SettingsLayout.Controls.Add(SaveSettingsButton, 1, 5);
            SettingsLayout.Controls.Add(ComPortSettingLabel, 0, 1);
            SettingsLayout.Controls.Add(SettingsLabel, 0, 0);
            SettingsLayout.Controls.Add(COMPortComboBox, 1, 1);
            SettingsLayout.Controls.Add(BaudRateTextBox, 1, 2);
            SettingsLayout.Controls.Add(USBScanToolPathTextBox, 1, 5);
            SettingsLayout.Dock = DockStyle.Fill;
            SettingsLayout.Location = new Point(0, 0);
            SettingsLayout.Name = "SettingsLayout";
            SettingsLayout.RowCount = 8;
            SettingsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            SettingsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            SettingsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            SettingsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            SettingsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            SettingsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            SettingsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            SettingsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            SettingsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            SettingsLayout.Size = new Size(287, 431);
            SettingsLayout.TabIndex = 0;
            // 
            // EQToolPathTextBox
            // 
            EQToolPathTextBox.Anchor = AnchorStyles.None;
            EQToolPathTextBox.Location = new Point(165, 258);
            EQToolPathTextBox.Name = "EQToolPathTextBox";
            EQToolPathTextBox.Size = new Size(100, 23);
            EQToolPathTextBox.TabIndex = 9;
            EQToolPathTextBox.Text = "Paste Path Here";
            EQToolPathTextBox.TextAlign = HorizontalAlignment.Center;
            EQToolPathTextBox.TextChanged += EQToolPathTextBox_TextChanged;
            // 
            // GameLauncherPathTextBox
            // 
            GameLauncherPathTextBox.Anchor = AnchorStyles.None;
            GameLauncherPathTextBox.Location = new Point(165, 198);
            GameLauncherPathTextBox.Name = "GameLauncherPathTextBox";
            GameLauncherPathTextBox.Size = new Size(100, 23);
            GameLauncherPathTextBox.TabIndex = 8;
            GameLauncherPathTextBox.Text = "Paste Path Here";
            GameLauncherPathTextBox.TextAlign = HorizontalAlignment.Center;
            GameLauncherPathTextBox.TextChanged += GameLauncherPathTextBox_TextChanged;
            // 
            // BaudRateSettingLabel
            // 
            BaudRateSettingLabel.Anchor = AnchorStyles.Right;
            BaudRateSettingLabel.AutoSize = true;
            BaudRateSettingLabel.Location = new Point(66, 142);
            BaudRateSettingLabel.Name = "BaudRateSettingLabel";
            BaudRateSettingLabel.Size = new Size(74, 15);
            BaudRateSettingLabel.TabIndex = 1;
            BaudRateSettingLabel.Text = "BAUD RATE :";
            // 
            // GameLauncherSettingLabel
            // 
            GameLauncherSettingLabel.Anchor = AnchorStyles.Right;
            GameLauncherSettingLabel.AutoSize = true;
            GameLauncherSettingLabel.Location = new Point(30, 202);
            GameLauncherSettingLabel.Name = "GameLauncherSettingLabel";
            GameLauncherSettingLabel.Size = new Size(110, 15);
            GameLauncherSettingLabel.TabIndex = 2;
            GameLauncherSettingLabel.Text = "GAME LAUNCHER :";
            // 
            // EQToolSettingLabel
            // 
            EQToolSettingLabel.Anchor = AnchorStyles.Right;
            EQToolSettingLabel.AutoSize = true;
            EQToolSettingLabel.Location = new Point(79, 262);
            EQToolSettingLabel.Name = "EQToolSettingLabel";
            EQToolSettingLabel.Size = new Size(61, 15);
            EQToolSettingLabel.TabIndex = 3;
            EQToolSettingLabel.Text = "EQ TOOL :";
            // 
            // USBScanToolSettingLabel
            // 
            USBScanToolSettingLabel.Anchor = AnchorStyles.Right;
            USBScanToolSettingLabel.AutoSize = true;
            USBScanToolSettingLabel.BackColor = SystemColors.InactiveCaptionText;
            USBScanToolSettingLabel.Location = new Point(39, 322);
            USBScanToolSettingLabel.Name = "USBScanToolSettingLabel";
            USBScanToolSettingLabel.Size = new Size(101, 15);
            USBScanToolSettingLabel.TabIndex = 4;
            USBScanToolSettingLabel.Text = "USB SCAN TOOL :";
            // 
            // SaveSettingsButton
            // 
            SaveSettingsButton.Anchor = AnchorStyles.Top;
            SettingsLayout.SetColumnSpan(SaveSettingsButton, 2);
            SaveSettingsButton.ForeColor = SystemColors.Desktop;
            SaveSettingsButton.Location = new Point(106, 363);
            SaveSettingsButton.Name = "SaveSettingsButton";
            SaveSettingsButton.Size = new Size(75, 23);
            SaveSettingsButton.TabIndex = 5;
            SaveSettingsButton.Text = "Save";
            SaveSettingsButton.UseVisualStyleBackColor = true;
            SaveSettingsButton.Click += SaveSettingsButton_Click;
            // 
            // ComPortSettingLabel
            // 
            ComPortSettingLabel.Anchor = AnchorStyles.Right;
            ComPortSettingLabel.AutoSize = true;
            ComPortSettingLabel.Location = new Point(67, 82);
            ComPortSettingLabel.Name = "ComPortSettingLabel";
            ComPortSettingLabel.Size = new Size(73, 15);
            ComPortSettingLabel.TabIndex = 0;
            ComPortSettingLabel.Text = "COM PORT :";
            // 
            // SettingsLabel
            // 
            SettingsLabel.Anchor = AnchorStyles.None;
            SettingsLabel.AutoSize = true;
            SettingsLayout.SetColumnSpan(SettingsLabel, 2);
            SettingsLabel.Font = new Font("Bahnschrift SemiBold Condensed", 20F, FontStyle.Bold);
            SettingsLabel.ForeColor = Color.Crimson;
            SettingsLabel.Location = new Point(94, 13);
            SettingsLabel.Name = "SettingsLabel";
            SettingsLabel.Size = new Size(99, 33);
            SettingsLabel.TabIndex = 6;
            SettingsLabel.Text = "SETTINGS";
            // 
            // COMPortComboBox
            // 
            COMPortComboBox.Anchor = AnchorStyles.None;
            COMPortComboBox.FormattingEnabled = true;
            COMPortComboBox.Items.AddRange(new object[] { "COM1", "COM2", "COM3" });
            COMPortComboBox.Location = new Point(154, 78);
            COMPortComboBox.Name = "COMPortComboBox";
            COMPortComboBox.Size = new Size(121, 23);
            COMPortComboBox.TabIndex = 1;
            COMPortComboBox.Text = "- Select COM Port -";
            COMPortComboBox.SelectedIndexChanged += COMPortComboBox_SelectedIndexChanged;
            // 
            // BaudRateTextBox
            // 
            BaudRateTextBox.Anchor = AnchorStyles.None;
            BaudRateTextBox.Location = new Point(165, 138);
            BaudRateTextBox.Name = "BaudRateTextBox";
            BaudRateTextBox.Size = new Size(100, 23);
            BaudRateTextBox.TabIndex = 7;
            BaudRateTextBox.Text = "9600";
            BaudRateTextBox.TextAlign = HorizontalAlignment.Center;
            BaudRateTextBox.TextChanged += BaudRateTextBox_TextChanged;
            // 
            // USBScanToolPathTextBox
            // 
            USBScanToolPathTextBox.Anchor = AnchorStyles.None;
            USBScanToolPathTextBox.Location = new Point(165, 318);
            USBScanToolPathTextBox.Name = "USBScanToolPathTextBox";
            USBScanToolPathTextBox.Size = new Size(100, 23);
            USBScanToolPathTextBox.TabIndex = 10;
            USBScanToolPathTextBox.Text = "Paste Path Here";
            USBScanToolPathTextBox.TextAlign = HorizontalAlignment.Center;
            USBScanToolPathTextBox.TextChanged += USBScanToolPathTextBox_TextChanged;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(287, 431);
            Controls.Add(SettingsLayout);
            ForeColor = SystemColors.Info;
            MaximumSize = new Size(303, 470);
            MinimumSize = new Size(303, 470);
            Name = "SettingsForm";
            Text = "Settings";
            Load += SettingsForm_Load;
            SettingsLayout.ResumeLayout(false);
            SettingsLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel SettingsLayout;
        private Label EQToolSettingLabel;
        private Label ComPortSettingLabel;
        private Label BaudRateSettingLabel;
        private Label GameLauncherSettingLabel;
        private Label USBScanToolSettingLabel;
        private Button SaveSettingsButton;
        private Label SettingsLabel;
        private ComboBox COMPortComboBox;
        private TextBox BaudRateTextBox;
        private TextBox EQToolPathTextBox;
        private TextBox GameLauncherPathTextBox;
        private TextBox USBScanToolPathTextBox;
    }
}