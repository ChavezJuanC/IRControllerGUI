using IRControllerGUI.ButtonMapperLib;

namespace IRControllerGUI
{
    public partial class MainFormWindow : Form
    {

        #region App INIT
        private readonly ControlButtonMapper mapper = new();


        public MainFormWindow()
        {
            InitializeComponent();
        }

        private void MainFormWindow_Load(object sender, EventArgs e)
        {
            // Connect Buttons
            Connect_IR_Butons();
        }

        #endregion

        #region IR Controller Button Methods
        //Connect all IR controller Buttons to their functions
        private IEnumerable<Button> GetAllButtons(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn && btn.Tag?.ToString() == "IRButton")
                    yield return btn;

                //checkign for children inside possibly nested components
                if (c.HasChildren)
                {
                    foreach (var childBtn in GetAllButtons(c))
                        yield return childBtn;
                }
            }
        }

        private void Connect_IR_Butons()
        {
            var buttons_array = GetAllButtons(this).ToArray();

            MessageBox.Show($"Found {buttons_array.Length} buttons");

            foreach (var button in buttons_array)
            {
                button.Click += (sender, e) => mapper.Handle_Button_Press(button);
            }
        }

        #endregion

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}

