using System.Linq;

namespace IRControllerGUI
{
    public partial class SettingsForm : Form
    {
        private static readonly System.Text.Json.JsonSerializerOptions _jsonOptions =
            new System.Text.Json.JsonSerializerOptions { WriteIndented = true };
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
            ProgramSettings settings;
            string settingsFile = "IR_Controller_GUI_Settings.json";

            if (File.Exists(settingsFile))
            {
                try // handle bad json
                {
                    var foundSettings = File.ReadAllText(settingsFile);
                    settings = System.Text.Json.JsonSerializer.Deserialize<ProgramSettings>(
                        foundSettings
                    )!;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error reading settings file. Defaults will be used.\n\n{ex.Message}"
                    );
                    settings = new ProgramSettings(
                        "COM3",
                        9600,
                        "launcher.exe",
                        "eqtool.exe",
                        "usbscan.exe"
                    );
                }
            }
            else
            {
                var defaultSettings = new ProgramSettings(
                    "COM3",
                    9600,
                    "launcher.exe",
                    "eqtool.exe",
                    "usbscan.exe"
                );
                settings = defaultSettings;

                var json = System.Text.Json.JsonSerializer.Serialize(defaultSettings, _jsonOptions);

                File.WriteAllText(settingsFile, json);
            }

            COM_PORT = settings.ComPortSettingsValue;
            BAUD_RATE = settings.BaudRateSettingsValue;
            GAME_LAUNCHER = settings.GameLauncher;
            EQ_TOOL = settings.EQTool;
            USB_SCAN_TOOL = settings.USBScanTool;

            var new_settings_json = System.Text.Json.JsonSerializer.Serialize(
                settings,
                _jsonOptions
            );

            File.WriteAllText(settingsFile, new_settings_json);
            PupulateSettingsForm();
        }

        private void PupulateSettingsForm()
        {
            COMPortComboBox.SelectedItem = COM_PORT;
            BaudRateTextBox.Text = BAUD_RATE.ToString();
            GameLauncherPathTextBox.Text = GAME_LAUNCHER;
            EQToolPathTextBox.Text = EQ_TOOL;
            USBScanToolPathTextBox.Text = USB_SCAN_TOOL;
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            var updatedSettings = new ProgramSettings(
                COM_PORT,
                BAUD_RATE,
                GAME_LAUNCHER,
                EQ_TOOL,
                USB_SCAN_TOOL
            );

            var settingsFile = "IR_Controller_GUI_Settings.json";
            var json = System.Text.Json.JsonSerializer.Serialize(updatedSettings, _jsonOptions);
            File.WriteAllText(settingsFile, json);

            this.Close();
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

        private void BaudRateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(BaudRateTextBox.Text, out int parsedBaudRate))
                BAUD_RATE = parsedBaudRate;
        }
    }
}
