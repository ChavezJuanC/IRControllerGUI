namespace IRControllerGUI
{
    public partial class SettingsForm : Form
    {
        private static string _comPort = string.Empty;
        private static int _baudRate;
        private static string _gameLauncher = string.Empty;
        private static string _eqTool = string.Empty;
        private static string _usbScanTool = string.Empty;

        public static string COM_PORT
        {
            get => _comPort;
            set => _comPort = value;
        }

        public static int BAUD_RATE
        {
            get => _baudRate;
            set => _baudRate = value;
        }

        public static string GAME_LAUNCHER
        {
            get => _gameLauncher;
            set => _gameLauncher = value;
        }

        public static string EQ_TOOL
        {
            get => _eqTool;
            set => _eqTool = value;
        }

        public static string USB_SCAN_TOOL
        {
            get => _usbScanTool;
            set => _usbScanTool = value;
        }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            //if settings file doesnt exist , create one with default settings

            // read from settings file and populate fields
            COM_PORT = "COM3";
            BAUD_RATE = 9600;
            GAME_LAUNCHER = "launcher.exe";
            EQ_TOOL = "eqtool.exe";
            USB_SCAN_TOOL = "usbscan.exe";
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show(
                $"Settings saved successfully!\n\n"
                    + $"COM Port: {COM_PORT}\n"
                    + $"Baud Rate: {BAUD_RATE}\n"
                    + $"Game Launcher: {GAME_LAUNCHER}\n"
                    + $"EQ Tool: {EQ_TOOL}\n"
                    + $"USB Scan Tool: {USB_SCAN_TOOL}",
                "Settings Saved"
            );
        }

        private void COMPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (COMPortComboBox.SelectedItem is string selectedPort)
                COM_PORT = selectedPort;
            else if (COMPortComboBox.SelectedItem != null)
                COM_PORT = COMPortComboBox.SelectedItem.ToString() ?? string.Empty;
        }

        private void GameLauncherPathTextBox_TextChanged(object sender, EventArgs e)
        {
            GAME_LAUNCHER = GameLauncherPathTextBox.Text;
        }

        private void EQToolPathTextBox_TextChanged(object sender, EventArgs e)
        {
            EQ_TOOL = EQToolPathTextBox.Text;
        }

        private void USBScanToolPathTextBox_TextChanged(object sender, EventArgs e)
        {
            USB_SCAN_TOOL = USBScanToolPathTextBox.Text;
        }
    }
}
