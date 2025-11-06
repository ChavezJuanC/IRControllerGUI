using System.IO.Ports;

namespace IRControllerGUI.Arduino
{
    internal class ArduinoSerialPortComs
    {
        private static SerialPort? _serialPort;
        private static Button[]? _IR_form_buttons;

        static ArduinoSerialPortComs()
        {
            try
            {
                _serialPort = new SerialPort(
                    SettingsForm.COM_PORT,
                    SettingsForm.BAUD_RATE,
                    Parity.None,
                    8,
                    StopBits.One
                );
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch
            {
                MessageBox.Show("Failed to initialize serial port. Please check your settings.");
                _serialPort = null;
            }
        }

        public static void DefFormButtons(Button[] button_list)
        {
            _IR_form_buttons = button_list;
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (_serialPort == null)
                    return;
                string receivedButtonName = _serialPort.ReadLine();
                RequestButtonAction(receivedButtonName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void StartSerailPort()
        {
            try
            {
                if (_serialPort == null)
                {
                    MessageBox.Show("Serial port is not initialized.");
                    return;
                }
                _serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port: " + ex.Message);
            }
        }

        private static void RequestButtonAction(string btn_name)
        {
            if (_IR_form_buttons == null)
                return;

            foreach (var btn in _IR_form_buttons)
            {
                if (btn.Name == btn_name.Trim())
                {
                    btn.PerformClick();
                }
            }
        }
    }
}
