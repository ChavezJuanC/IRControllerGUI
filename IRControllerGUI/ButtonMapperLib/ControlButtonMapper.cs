using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRControllerGUI.ButtonMapperLib
{
    public class ControlButtonMapper
    {
        public void Handle_Button_Press(Button pressedButton)
        {
            MessageBox.Show($"Button Pressed: {pressedButton.Name}"); 
        }
    }
}





