namespace TelevisionApplication
{
    internal class Television
    {
        public bool PowerState { get; private set; }
        public string Model { get; private set; }
        public RemoteControl RemoteControl { get; private set; }
        public Dictionary<string, AVConnection.AVConnectionType> AVInputConnections { get; private set; }
        public Dictionary<string, AudioVideoDevice> RegisteredAVDevices { get; private set; }
        
        public Television(string model, Dictionary<string, AVConnection.AVConnectionType> avInputConnections) 
        {
            Model = model;
            AVInputConnections = avInputConnections;
            RegisteredAVDevices = new Dictionary<string, AudioVideoDevice>();
        }

        public void RegisterRemoteControl(RemoteControl remoteControl)
        {
            if (RemoteControl != null)
            {
                Console.WriteLine(RemoteControl.RemoteControlName + " is now de-registered.");
            }

            RemoteControl = remoteControl;
            Console.WriteLine(remoteControl.RemoteControlName + " is now registered.");
        }

        public void RegisterAVDevice(AudioVideoDevice AVDevice, string avInputKey)
        {
            AVDevice.RegisterTelevision(this, avInputKey);
        }
    }
}
