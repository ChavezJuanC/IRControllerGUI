namespace IRControllerGUI.Data
{
    public class MappableButtonSet
    {
        public string ButtonName { get; set; } = string.Empty;
        public string ButtonFilePath { get; set; } = string.Empty;

        public MappableButtonSet() { } // Parameterless constructor for deserialization

        public MappableButtonSet(string buttonName, string buttonFilePath)
        {
            ButtonName = buttonName;
            ButtonFilePath = buttonFilePath;
        }
    }
}
