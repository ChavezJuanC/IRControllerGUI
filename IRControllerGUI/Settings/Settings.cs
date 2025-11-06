using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRControllerGUI.Settings
{
    public class Settings
    {
        public string ComPortSettingsValue { get; set; } = string.Empty;
        public int BaudRateSettingsValue { get; set; }
        public string GameLauncher { get; set; } = string.Empty;
        public string EQTool { get; set; } = string.Empty;
        public string USBScanTool { get; set; } = string.Empty;
    }
}
