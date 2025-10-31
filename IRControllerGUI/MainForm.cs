using System.Diagnostics;
using IRControllerGUI.Arduino;
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

        public MainFormWindow()
        {
            InitializeComponent();
            Arduino.ArduinoSerialPortComs.StartSerailPort();
        }

        private void MainFormWindow_Load(object sender, EventArgs e)
        {
            // Connect buttons
            ConnectFixedIRButons();
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

        private void ConnectFixedIRButons()
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

        private void EditorAssignButton_Click(object sender, EventArgs e)
        {
            //evaluate string and assign a function to the correct button's Clicked event
            AsignExecuteableToButton(CurrentlySelectedExecutableFilePath, SelectedButtonString);
        }

        private void AsignExecuteableToButton(string filePath, string buttonNameString)
        {
            if (ProgramableButtons != null)
            {
                foreach (var btn in ProgramableButtons)
                {
                    if (btn.Name == buttonNameString)
                    {
                        MessageBox.Show(
                            $"Assigning button {buttonNameString} to lauch file : {filePath}"
                        );
                        btn.Click -= Button_Click_LaunchExecutable;
                        btn.Click += Button_Click_LaunchExecutable;
                        return;
                    }
                }
            }
        }

        private void Button_Click_LaunchExecutable(object? sender, EventArgs e)
        {
            MessageBox.Show($"Opening File: {CurrentlySelectedExecutableFilePath}");
            WindowsInteractions.OpenExecuteableInd(CurrentlySelectedExecutableFilePath);
        }

        #endregion
    }
}
