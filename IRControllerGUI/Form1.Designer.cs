namespace IRControllerGUI
{
    partial class MainFormWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ControlLayoutPanel = new TableLayoutPanel();
            Button_9 = new Button();
            Button_8 = new Button();
            Button_7 = new Button();
            Button_6 = new Button();
            Button_5 = new Button();
            Button_4 = new Button();
            Button_3 = new Button();
            Button_2 = new Button();
            Button_1 = new Button();
            IRUSBScanButton = new Button();
            IRRefreshButton = new Button();
            Button_0 = new Button();
            IRVolUpButton = new Button();
            IRVolDownButton = new Button();
            IREQButton = new Button();
            IRPrevButton = new Button();
            IRNextButton = new Button();
            IRPlayButton = new Button();
            IRMuteButton = new Button();
            IRModeButton = new Button();
            IRPowerButton = new Button();
            MainLayoutPanel = new TableLayoutPanel();
            AppTitleLabel = new Label();
            EditorLayoutPanel = new TableLayoutPanel();
            EditorFileLabel = new Label();
            label1 = new Label();
            EditorButtonLabel = new Label();
            EditorFilePathLabel = new Label();
            ButtonPickerDropDown = new ComboBox();
            FindFileButton = new Button();
            EditorAssignButton = new Button();
            button2 = new Button();
            q = new Label();
            ExecuteableFileDialog = new OpenFileDialog();
            ControlLayoutPanel.SuspendLayout();
            MainLayoutPanel.SuspendLayout();
            EditorLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ControlLayoutPanel
            // 
            ControlLayoutPanel.Anchor = AnchorStyles.Right;
            ControlLayoutPanel.ColumnCount = 3;
            ControlLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            ControlLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            ControlLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            ControlLayoutPanel.Controls.Add(Button_9, 2, 6);
            ControlLayoutPanel.Controls.Add(Button_8, 1, 6);
            ControlLayoutPanel.Controls.Add(Button_7, 0, 6);
            ControlLayoutPanel.Controls.Add(Button_6, 2, 5);
            ControlLayoutPanel.Controls.Add(Button_5, 1, 5);
            ControlLayoutPanel.Controls.Add(Button_4, 0, 5);
            ControlLayoutPanel.Controls.Add(Button_3, 2, 4);
            ControlLayoutPanel.Controls.Add(Button_2, 1, 4);
            ControlLayoutPanel.Controls.Add(Button_1, 0, 4);
            ControlLayoutPanel.Controls.Add(IRUSBScanButton, 2, 3);
            ControlLayoutPanel.Controls.Add(IRRefreshButton, 1, 3);
            ControlLayoutPanel.Controls.Add(Button_0, 0, 3);
            ControlLayoutPanel.Controls.Add(IRVolUpButton, 2, 2);
            ControlLayoutPanel.Controls.Add(IRVolDownButton, 1, 2);
            ControlLayoutPanel.Controls.Add(IREQButton, 0, 2);
            ControlLayoutPanel.Controls.Add(IRPrevButton, 2, 1);
            ControlLayoutPanel.Controls.Add(IRNextButton, 1, 1);
            ControlLayoutPanel.Controls.Add(IRPlayButton, 0, 1);
            ControlLayoutPanel.Controls.Add(IRMuteButton, 2, 0);
            ControlLayoutPanel.Controls.Add(IRModeButton, 1, 0);
            ControlLayoutPanel.Controls.Add(IRPowerButton, 0, 0);
            ControlLayoutPanel.Location = new Point(33, 139);
            ControlLayoutPanel.Name = "ControlLayoutPanel";
            ControlLayoutPanel.RowCount = 7;
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ControlLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ControlLayoutPanel.Size = new Size(298, 266);
            ControlLayoutPanel.TabIndex = 0;
            // 
            // Button_9
            // 
            Button_9.Dock = DockStyle.Fill;
            Button_9.ForeColor = Color.Black;
            Button_9.Location = new Point(201, 231);
            Button_9.Name = "Button_9";
            Button_9.Size = new Size(94, 32);
            Button_9.TabIndex = 20;
            Button_9.Tag = "IRButtonProgramable";
            Button_9.Text = "9";
            Button_9.UseVisualStyleBackColor = true;
            // 
            // Button_8
            // 
            Button_8.Dock = DockStyle.Fill;
            Button_8.ForeColor = Color.Black;
            Button_8.Location = new Point(102, 231);
            Button_8.Name = "Button_8";
            Button_8.Size = new Size(93, 32);
            Button_8.TabIndex = 19;
            Button_8.Tag = "IRButtonProgramable";
            Button_8.Text = "8";
            Button_8.UseVisualStyleBackColor = true;
            // 
            // Button_7
            // 
            Button_7.Dock = DockStyle.Fill;
            Button_7.ForeColor = Color.Black;
            Button_7.Location = new Point(3, 231);
            Button_7.Name = "Button_7";
            Button_7.Size = new Size(93, 32);
            Button_7.TabIndex = 18;
            Button_7.Tag = "IRButtonProgramable";
            Button_7.Text = "7";
            Button_7.UseVisualStyleBackColor = true;
            // 
            // Button_6
            // 
            Button_6.Dock = DockStyle.Fill;
            Button_6.ForeColor = Color.Black;
            Button_6.Location = new Point(201, 193);
            Button_6.Name = "Button_6";
            Button_6.Size = new Size(94, 32);
            Button_6.TabIndex = 17;
            Button_6.Tag = "IRButtonProgramable";
            Button_6.Text = "6";
            Button_6.UseVisualStyleBackColor = true;
            // 
            // Button_5
            // 
            Button_5.Dock = DockStyle.Fill;
            Button_5.ForeColor = Color.Black;
            Button_5.Location = new Point(102, 193);
            Button_5.Name = "Button_5";
            Button_5.Size = new Size(93, 32);
            Button_5.TabIndex = 16;
            Button_5.Tag = "IRButtonProgramable";
            Button_5.Text = "5";
            Button_5.UseVisualStyleBackColor = true;
            // 
            // Button_4
            // 
            Button_4.Dock = DockStyle.Fill;
            Button_4.ForeColor = Color.Black;
            Button_4.Location = new Point(3, 193);
            Button_4.Name = "Button_4";
            Button_4.Size = new Size(93, 32);
            Button_4.TabIndex = 15;
            Button_4.Tag = "IRButtonProgramable";
            Button_4.Text = "4";
            Button_4.UseVisualStyleBackColor = true;
            // 
            // Button_3
            // 
            Button_3.Dock = DockStyle.Fill;
            Button_3.ForeColor = Color.Black;
            Button_3.Location = new Point(201, 155);
            Button_3.Name = "Button_3";
            Button_3.Size = new Size(94, 32);
            Button_3.TabIndex = 14;
            Button_3.Tag = "IRButtonProgramable";
            Button_3.Text = "3";
            Button_3.UseVisualStyleBackColor = true;
            // 
            // Button_2
            // 
            Button_2.Dock = DockStyle.Fill;
            Button_2.ForeColor = Color.Black;
            Button_2.Location = new Point(102, 155);
            Button_2.Name = "Button_2";
            Button_2.Size = new Size(93, 32);
            Button_2.TabIndex = 13;
            Button_2.Tag = "IRButtonProgramable";
            Button_2.Text = "2";
            Button_2.UseVisualStyleBackColor = true;
            // 
            // Button_1
            // 
            Button_1.Dock = DockStyle.Fill;
            Button_1.ForeColor = Color.Black;
            Button_1.Location = new Point(3, 155);
            Button_1.Name = "Button_1";
            Button_1.Size = new Size(93, 32);
            Button_1.TabIndex = 12;
            Button_1.Tag = "IRButtonProgramable";
            Button_1.Text = "1";
            Button_1.UseVisualStyleBackColor = true;
            // 
            // IRUSBScanButton
            // 
            IRUSBScanButton.Dock = DockStyle.Fill;
            IRUSBScanButton.ForeColor = Color.Black;
            IRUSBScanButton.Location = new Point(201, 117);
            IRUSBScanButton.Name = "IRUSBScanButton";
            IRUSBScanButton.Size = new Size(94, 32);
            IRUSBScanButton.TabIndex = 11;
            IRUSBScanButton.Tag = "IRButton";
            IRUSBScanButton.Text = "USB Scan";
            IRUSBScanButton.UseVisualStyleBackColor = true;
            // 
            // IRRefreshButton
            // 
            IRRefreshButton.Dock = DockStyle.Fill;
            IRRefreshButton.ForeColor = Color.Black;
            IRRefreshButton.Location = new Point(102, 117);
            IRRefreshButton.Name = "IRRefreshButton";
            IRRefreshButton.Size = new Size(93, 32);
            IRRefreshButton.TabIndex = 10;
            IRRefreshButton.Tag = "IRButton";
            IRRefreshButton.Text = "Refresh";
            IRRefreshButton.UseVisualStyleBackColor = true;
            // 
            // Button_0
            // 
            Button_0.Dock = DockStyle.Fill;
            Button_0.ForeColor = Color.Black;
            Button_0.Location = new Point(3, 117);
            Button_0.Name = "Button_0";
            Button_0.Size = new Size(93, 32);
            Button_0.TabIndex = 9;
            Button_0.Tag = "IRButtonProgramable";
            Button_0.Text = "0";
            Button_0.UseVisualStyleBackColor = true;
            // 
            // IRVolUpButton
            // 
            IRVolUpButton.Dock = DockStyle.Fill;
            IRVolUpButton.ForeColor = Color.Black;
            IRVolUpButton.Location = new Point(201, 79);
            IRVolUpButton.Name = "IRVolUpButton";
            IRVolUpButton.Size = new Size(94, 32);
            IRVolUpButton.TabIndex = 8;
            IRVolUpButton.Tag = "IRButton";
            IRVolUpButton.Text = "Vol Up";
            IRVolUpButton.UseVisualStyleBackColor = true;
            // 
            // IRVolDownButton
            // 
            IRVolDownButton.Dock = DockStyle.Fill;
            IRVolDownButton.ForeColor = Color.Black;
            IRVolDownButton.Location = new Point(102, 79);
            IRVolDownButton.Name = "IRVolDownButton";
            IRVolDownButton.Size = new Size(93, 32);
            IRVolDownButton.TabIndex = 7;
            IRVolDownButton.Tag = "IRButton";
            IRVolDownButton.Text = "Vol Down";
            IRVolDownButton.UseVisualStyleBackColor = true;
            // 
            // IREQButton
            // 
            IREQButton.Dock = DockStyle.Fill;
            IREQButton.ForeColor = Color.Black;
            IREQButton.Location = new Point(3, 79);
            IREQButton.Name = "IREQButton";
            IREQButton.Size = new Size(93, 32);
            IREQButton.TabIndex = 6;
            IREQButton.Tag = "IRButton";
            IREQButton.Text = "EQ";
            IREQButton.UseVisualStyleBackColor = true;
            // 
            // IRPrevButton
            // 
            IRPrevButton.Dock = DockStyle.Fill;
            IRPrevButton.ForeColor = Color.Black;
            IRPrevButton.Location = new Point(201, 41);
            IRPrevButton.Name = "IRPrevButton";
            IRPrevButton.Size = new Size(94, 32);
            IRPrevButton.TabIndex = 5;
            IRPrevButton.Tag = "IRButton";
            IRPrevButton.Text = "Prev Track";
            IRPrevButton.UseVisualStyleBackColor = true;
            // 
            // IRNextButton
            // 
            IRNextButton.Dock = DockStyle.Fill;
            IRNextButton.ForeColor = Color.Black;
            IRNextButton.Location = new Point(102, 41);
            IRNextButton.Name = "IRNextButton";
            IRNextButton.Size = new Size(93, 32);
            IRNextButton.TabIndex = 4;
            IRNextButton.Tag = "IRButton";
            IRNextButton.Text = "Next Track";
            IRNextButton.UseVisualStyleBackColor = true;
            // 
            // IRPlayButton
            // 
            IRPlayButton.Dock = DockStyle.Fill;
            IRPlayButton.ForeColor = Color.Black;
            IRPlayButton.Location = new Point(3, 41);
            IRPlayButton.Name = "IRPlayButton";
            IRPlayButton.Size = new Size(93, 32);
            IRPlayButton.TabIndex = 3;
            IRPlayButton.Tag = "IRButton";
            IRPlayButton.Text = "Play/Stop";
            IRPlayButton.UseVisualStyleBackColor = true;
            // 
            // IRMuteButton
            // 
            IRMuteButton.Dock = DockStyle.Fill;
            IRMuteButton.ForeColor = Color.Black;
            IRMuteButton.Location = new Point(201, 3);
            IRMuteButton.Name = "IRMuteButton";
            IRMuteButton.Size = new Size(94, 32);
            IRMuteButton.TabIndex = 2;
            IRMuteButton.Tag = "IRButton";
            IRMuteButton.Text = "Mute";
            IRMuteButton.UseVisualStyleBackColor = true;
            // 
            // IRModeButton
            // 
            IRModeButton.Dock = DockStyle.Fill;
            IRModeButton.ForeColor = Color.Black;
            IRModeButton.Location = new Point(102, 3);
            IRModeButton.Name = "IRModeButton";
            IRModeButton.Size = new Size(93, 32);
            IRModeButton.TabIndex = 1;
            IRModeButton.Tag = "IRButton";
            IRModeButton.Text = "Mode";
            IRModeButton.UseVisualStyleBackColor = true;
            // 
            // IRPowerButton
            // 
            IRPowerButton.Dock = DockStyle.Fill;
            IRPowerButton.ForeColor = Color.Black;
            IRPowerButton.Location = new Point(3, 3);
            IRPowerButton.Name = "IRPowerButton";
            IRPowerButton.Size = new Size(93, 32);
            IRPowerButton.TabIndex = 0;
            IRPowerButton.Tag = "IRButton";
            IRPowerButton.Text = "Power";
            IRPowerButton.UseVisualStyleBackColor = true;
            // 
            // MainLayoutPanel
            // 
            MainLayoutPanel.ColumnCount = 2;
            MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainLayoutPanel.Controls.Add(ControlLayoutPanel, 0, 1);
            MainLayoutPanel.Controls.Add(AppTitleLabel, 0, 0);
            MainLayoutPanel.Controls.Add(EditorLayoutPanel, 1, 1);
            MainLayoutPanel.Controls.Add(button2, 1, 2);
            MainLayoutPanel.Controls.Add(q, 0, 2);
            MainLayoutPanel.Dock = DockStyle.Fill;
            MainLayoutPanel.ForeColor = Color.Coral;
            MainLayoutPanel.Location = new Point(0, 0);
            MainLayoutPanel.Name = "MainLayoutPanel";
            MainLayoutPanel.RowCount = 3;
            MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 27.3364487F));
            MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 72.66355F));
            MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            MainLayoutPanel.Size = new Size(669, 521);
            MainLayoutPanel.TabIndex = 1;
            MainLayoutPanel.Tag = "";
            // 
            // AppTitleLabel
            // 
            AppTitleLabel.Anchor = AnchorStyles.None;
            AppTitleLabel.AutoSize = true;
            MainLayoutPanel.SetColumnSpan(AppTitleLabel, 2);
            AppTitleLabel.Font = new Font("Bahnschrift Condensed", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppTitleLabel.ForeColor = Color.Crimson;
            AppTitleLabel.Location = new Point(158, 36);
            AppTitleLabel.Name = "AppTitleLabel";
            AppTitleLabel.Size = new Size(352, 45);
            AppTitleLabel.TabIndex = 1;
            AppTitleLabel.Text = "PC Remote Control Settings";
            AppTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditorLayoutPanel
            // 
            EditorLayoutPanel.Anchor = AnchorStyles.Left;
            EditorLayoutPanel.ColumnCount = 2;
            EditorLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EditorLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EditorLayoutPanel.Controls.Add(EditorFileLabel, 0, 3);
            EditorLayoutPanel.Controls.Add(label1, 0, 0);
            EditorLayoutPanel.Controls.Add(EditorButtonLabel, 0, 1);
            EditorLayoutPanel.Controls.Add(EditorFilePathLabel, 0, 2);
            EditorLayoutPanel.Controls.Add(ButtonPickerDropDown, 1, 1);
            EditorLayoutPanel.Controls.Add(FindFileButton, 1, 2);
            EditorLayoutPanel.Controls.Add(EditorAssignButton, 0, 4);
            EditorLayoutPanel.Location = new Point(337, 143);
            EditorLayoutPanel.Name = "EditorLayoutPanel";
            EditorLayoutPanel.RowCount = 5;
            EditorLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            EditorLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            EditorLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            EditorLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.633094F));
            EditorLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 32.01439F));
            EditorLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            EditorLayoutPanel.Size = new Size(298, 259);
            EditorLayoutPanel.TabIndex = 2;
            // 
            // EditorFileLabel
            // 
            EditorFileLabel.AutoSize = true;
            EditorLayoutPanel.SetColumnSpan(EditorFileLabel, 2);
            EditorFileLabel.Dock = DockStyle.Fill;
            EditorFileLabel.ForeColor = Color.White;
            EditorFileLabel.Location = new Point(3, 153);
            EditorFileLabel.Name = "EditorFileLabel";
            EditorFileLabel.Size = new Size(292, 22);
            EditorFileLabel.TabIndex = 5;
            EditorFileLabel.Text = "File :";
            EditorFileLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            EditorLayoutPanel.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(292, 51);
            label1.TabIndex = 0;
            label1.Text = "Costumize Buttons";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // EditorButtonLabel
            // 
            EditorButtonLabel.AutoSize = true;
            EditorButtonLabel.Dock = DockStyle.Fill;
            EditorButtonLabel.ForeColor = Color.White;
            EditorButtonLabel.Location = new Point(3, 51);
            EditorButtonLabel.Name = "EditorButtonLabel";
            EditorButtonLabel.Size = new Size(143, 51);
            EditorButtonLabel.TabIndex = 1;
            EditorButtonLabel.Text = "Button :";
            EditorButtonLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditorFilePathLabel
            // 
            EditorFilePathLabel.AutoSize = true;
            EditorFilePathLabel.Dock = DockStyle.Fill;
            EditorFilePathLabel.ForeColor = Color.White;
            EditorFilePathLabel.Location = new Point(3, 102);
            EditorFilePathLabel.Name = "EditorFilePathLabel";
            EditorFilePathLabel.Size = new Size(143, 51);
            EditorFilePathLabel.TabIndex = 2;
            EditorFilePathLabel.Text = "File Path :";
            EditorFilePathLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonPickerDropDown
            // 
            ButtonPickerDropDown.Anchor = AnchorStyles.None;
            ButtonPickerDropDown.FormattingEnabled = true;
            ButtonPickerDropDown.Location = new Point(163, 65);
            ButtonPickerDropDown.Name = "ButtonPickerDropDown";
            ButtonPickerDropDown.Size = new Size(121, 23);
            ButtonPickerDropDown.TabIndex = 3;
            ButtonPickerDropDown.SelectedIndexChanged += ButtonPickerDropDown_SelectedIndexChanged;
            // 
            // FindFileButton
            // 
            FindFileButton.Anchor = AnchorStyles.None;
            FindFileButton.ForeColor = Color.Black;
            FindFileButton.Location = new Point(186, 116);
            FindFileButton.Name = "FindFileButton";
            FindFileButton.Size = new Size(75, 23);
            FindFileButton.TabIndex = 4;
            FindFileButton.Text = "Find File";
            FindFileButton.UseVisualStyleBackColor = true;
            FindFileButton.Click += FindFileButton_Click;
            // 
            // EditorAssignButton
            // 
            EditorAssignButton.Anchor = AnchorStyles.None;
            EditorLayoutPanel.SetColumnSpan(EditorAssignButton, 2);
            EditorAssignButton.ForeColor = Color.Black;
            EditorAssignButton.Location = new Point(111, 205);
            EditorAssignButton.Name = "EditorAssignButton";
            EditorAssignButton.Size = new Size(75, 23);
            EditorAssignButton.TabIndex = 6;
            EditorAssignButton.Text = "Assign";
            EditorAssignButton.UseVisualStyleBackColor = true;
            EditorAssignButton.Click += EditorAssignButton_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(564, 463);
            button2.Margin = new Padding(3, 3, 30, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Info";
            button2.UseVisualStyleBackColor = true;
            // 
            // q
            // 
            q.Anchor = AnchorStyles.None;
            q.AutoSize = true;
            q.BackColor = SystemColors.InfoText;
            q.ForeColor = Color.Aquamarine;
            q.Location = new Point(115, 467);
            q.Name = "q";
            q.Size = new Size(103, 15);
            q.TabIndex = 4;
            q.Text = "GitHub: @SKRPTZ";
            // 
            // MainFormWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(669, 521);
            Controls.Add(MainLayoutPanel);
            Name = "MainFormWindow";
            Text = "PC Remote Control";
            Load += MainFormWindow_Load;
            ControlLayoutPanel.ResumeLayout(false);
            MainLayoutPanel.ResumeLayout(false);
            MainLayoutPanel.PerformLayout();
            EditorLayoutPanel.ResumeLayout(false);
            EditorLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ControlLayoutPanel;
        private TableLayoutPanel MainLayoutPanel;
        private Label AppTitleLabel;
        private Button IRPowerButton;
        private Button IRPlayButton;
        private Button IRMuteButton;
        private Button IRModeButton;
        private Button Button_0;
        private Button IRVolUpButton;
        private Button IRVolDownButton;
        private Button IREQButton;
        private Button IRPrevButton;
        private Button IRNextButton;
        private Button Button_9;
        private Button Button_8;
        private Button Button_7;
        private Button Button_6;
        private Button Button_5;
        private Button Button_4;
        private Button Button_3;
        private Button Button_2;
        private Button Button_1;
        private Button IRUSBScanButton;
        private Button IRRefreshButton;
        private TableLayoutPanel EditorLayoutPanel;
        private Label label1;
        private Label EditorButtonLabel;
        private Label EditorFilePathLabel;
        private ComboBox ButtonPickerDropDown;
        private Button FindFileButton;
        private Label EditorFileLabel;
        private Button EditorAssignButton;
        private Button button2;
        private Label q;
        private OpenFileDialog ExecuteableFileDialog;
    }
}
