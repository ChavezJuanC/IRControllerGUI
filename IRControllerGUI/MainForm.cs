using System.Diagnostics;
using System.Text.Json;
using IRControllerGUI.Data;
using IRControllerGUI.WindowsInteractionsLib;

namespace IRControllerGUI
{
    public partial class MainFormWindow : Form
    {
        #region App INIT
        private readonly WindowsInteractions windows_iteraction_client = new();

        //File dialog for execuateble file
        public string CurrentlySelectedExecutableFilePath { get; set; } = string.Empty;
        public string SelectedButtonString { get; set; } = string.Empty;

        //Buttons
        public Button[]? FixedButtons = null;
        public Button[]? ProgramableButtons = null;

        // Button map file path
        private string _buttonMapFile =
            AppDomain.CurrentDomain.BaseDirectory + "\\Data\\mappable_buttons_data.json";

        //Settings
        private SettingsForm _settings = new();

        public MainFormWindow()
        {
            InitializeComponent();
            _settings.ShowDialog();
            Arduino.ArduinoSerialPortComs.StartSerailPort();
        }

        private void MainFormWindow_Load(object sender, EventArgs e)
        {
            // Connect buttons
            ConnectFixedIRButtons();
            FetchReprogramableButtons();

            if (FixedButtons != null && ProgramableButtons != null)
            {
                Button[] all_form_buttons = FixedButtons.Concat(ProgramableButtons).ToArray();
                Arduino.ArduinoSerialPortComs.DefFormButtons(all_form_buttons);

                foreach (var btn in all_form_buttons)
                {
                    Debug.WriteLine(btn.Name);
                }
            }

            // Feed mappable buttons dropdown
            LoadDropDownOptions();

            //Map asignable buttons from saved settings
            MapNumberedButtons();

            //Allow only execuable files in file dialog
            ExecuteableFileDialog.Filter = "Executable files (*.exe)|*.exe";
            ExecuteableFileDialog.Title = "Select an executable file";
        }

        private void LoadDropDownOptions()
        {
            ButtonPickerDropDown.Items.AddRange(
                [
                    "Button_0",
                    "Button_1",
                    "Button_2",
                    "Button_3",
                    "Button_4",
                    "Button_5",
                    "Button_6",
                    "Button_7",
                    "Button_8",
                    "Button_9",
                ]
            );
            ButtonPickerDropDown.SelectedIndex = 0;
        }

        #endregion

        #region IR Controller Button Methods
        //Connect all IR controller Buttons to their functions
        public static IEnumerable<Button> GetAllFixedButtons(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn && btn.Tag?.ToString() == "IRButton")
                    yield return btn;

                //checkign for children inside possibly nested components
                if (c.HasChildren)
                {
                    foreach (var childBtn in GetAllFixedButtons(c))
                        yield return childBtn;
                }
            }
        }

        public static IEnumerable<Button> GetAllProgramableButtons(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn && btn.Tag?.ToString() == "IRButtonProgramable")
                    yield return btn;

                //checkign for children inside possibly nested components
                if (c.HasChildren)
                {
                    foreach (var childBtn in GetAllProgramableButtons(c))
                        yield return childBtn;
                }
            }
        }

        private void ConnectFixedIRButtons()
        {
            FixedButtons = GetAllFixedButtons(this).ToArray();
            foreach (var button in FixedButtons) // Bind all functions to each FIXED button.
            {
                WindowsInteractions.DesignateBtn(button);
            }
        }

        #endregion

        #region Reprogramable Button Mapping Settings

        private void FetchReprogramableButtons()
        {
            ProgramableButtons = GetAllProgramableButtons(this).ToArray();
        }

        private void ButtonPickerDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ButtonPickerDropDown.SelectedItem is string selected)
            {
                SelectedButtonString = selected;
            }
        }

        private void FindFileButton_Click(object sender, EventArgs e)
        {
            ExecuteableFileDialog.ShowDialog();
            CurrentlySelectedExecutableFilePath = ExecuteableFileDialog.FileName.ToString();
            EditorFileLabel.Text = ($"File:({CurrentlySelectedExecutableFilePath})");
        }

        //Map buttons to files from (saved settings)
        public void MapNumberedButtons()
        {
            List<MappableButtonSet> currentButtonMap = FetchButtonMap();

            if (ProgramableButtons != null)
            {
                foreach (Button btn in ProgramableButtons)
                {
                    //check if any button's name in currentButtonMap matches this buttons name
                    currentButtonMap.ForEach(b =>
                    {
                        if (b.ButtonName == btn.Name && b.ButtonFilePath != String.Empty)
                        {
                            AsignExecuteableToButton(b.ButtonFilePath, b.ButtonName);
                        }
                    });
                }
            }
        }

        //Fetch map file for buttons
        private List<MappableButtonSet> FetchButtonMap()
        {
            string buttonMappingData = File.ReadAllText(_buttonMapFile);

            List<MappableButtonSet> mappableButtonsList =
                JsonSerializer.Deserialize<List<MappableButtonSet>>(buttonMappingData)
                ?? new List<MappableButtonSet>();

            return mappableButtonsList;
        }

        //Update map file
        public void UpdateButtonMap(List<MappableButtonSet> buttonMap)
        {
            foreach (MappableButtonSet buttonSet in buttonMap)
            {
                if (buttonSet.ButtonName == SelectedButtonString)
                {
                    buttonSet.ButtonFilePath = CurrentlySelectedExecutableFilePath;
                    break;
                }
            }

            //write to file
            string updatedJson = JsonSerializer.Serialize(
                buttonMap,
                new JsonSerializerOptions { WriteIndented = true }
            );
            File.WriteAllText(_buttonMapFile, updatedJson);
        }

        private void EditorAssignButton_Click(object sender, EventArgs e)
        {
            //evaluate string and assign a function to the correct button's Clicked event
            AsignExecuteableToButton(CurrentlySelectedExecutableFilePath, SelectedButtonString);

            //update settings file for mem..
            List<MappableButtonSet> buttonMap = FetchButtonMap();
            UpdateButtonMap(buttonMap);

            //for now just store in.. we can find a way to use it later.
        }

        // store references to handlers
        private readonly Dictionary<Button, EventHandler> buttonHandlers = new();

        private void AsignExecuteableToButton(string filePath, string buttonNameString)
        {
            if (ProgramableButtons == null)
            {
                return;
            }

            foreach (var btn in ProgramableButtons)
            {
                if (btn.Name.Equals(buttonNameString, StringComparison.CurrentCultureIgnoreCase))
                {
                    // remove old handler if exists
                    if (buttonHandlers.TryGetValue(btn, out var oldHandler))
                    {
                        btn.Click -= oldHandler;
                    }

                    EventHandler newHandler = (s, e) =>
                        Button_Click_LaunchExecutable(s, e, filePath);
                    btn.Click += newHandler;
                    buttonHandlers[btn] = newHandler;

                    MessageBox.Show($"Assigned {btn.Name} to launch {filePath}");
                    return;
                }
            }
        }

        private static void Button_Click_LaunchExecutable(object? sender, EventArgs e, string path)
        {
            WindowsInteractions.OpenExecuteableInd(path);
        }

        #endregion

        // Settings Button - Open Settings Form
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            _settings.ShowDialog();
        }
    }
}
