namespace TelevisionApplication
{
    internal class RemoteControl
    {
        public string RemoteControlName { get; private set; }
        public Dictionary<string, RemoteControlButton> ButtonList { get; private set; }

        public RemoteControl(string remoteControlName) 
        {
            RemoteControlName = remoteControlName;
        }
    }
}
