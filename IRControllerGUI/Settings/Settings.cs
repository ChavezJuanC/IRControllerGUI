public class ProgramSettings
{
    public string ComPortSettingsValue { get; set; } = string.Empty;
    public int BaudRateSettingsValue { get; set; }
    public string GameLauncher { get; set; } = string.Empty;
    public string EQTool { get; set; } = string.Empty;
    public string USBScanTool { get; set; } = string.Empty;

    public ProgramSettings() { } // for JSON deserialization

    public ProgramSettings(
        string ComPortSettingsValue,
        int BaudRateSettingsValue,
        string GameLauncher,
        string EQTool,
        string USBScanTool
    )
    {
        this.ComPortSettingsValue = ComPortSettingsValue;
        this.BaudRateSettingsValue = BaudRateSettingsValue;
        this.GameLauncher = GameLauncher;
        this.EQTool = EQTool;
        this.USBScanTool = USBScanTool;
    }
}
