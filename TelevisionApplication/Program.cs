namespace TelevisionApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a television
            Television myTelevision = new Television(
                "Samsung", new Dictionary<string, AVConnection.AVConnectionType>
                {
                    { "Comp (YPbPr)", AVConnection.AVConnectionType.Component },
                    { "HDMI1", AVConnection.AVConnectionType.HDMI },
                    { "HDMI2", AVConnection.AVConnectionType.HDMI },
                    { "HDMI3", AVConnection.AVConnectionType.HDMI },
                }
            );

            //Create a new Remote Control and register it to the television
            RemoteControl remoteControl = new RemoteControl("My Remote Control");
            myTelevision.RegisterRemoteControl(remoteControl);

            //Create an Apple TV and register it to the television
            AppleTV appleTV = new AppleTV("My Apple TV", AVConnection.AVConnectionType.HDMI);
            myTelevision.RegisterAVDevice(appleTV, "HDMI1");

            //Create a new laptop with an HDMI connection
            PersonalComputer laptop = new PersonalComputer("William's Laptop", AVConnection.AVConnectionType.HDMI, "Chrome");
            myTelevision.RegisterAVDevice(laptop, "HDMI2");

            //Create a new desktop with a DisplayPort connection
            PersonalComputer desktop = new PersonalComputer("William's Desktop", AVConnection.AVConnectionType.DisplayPort, "Chrome");
            myTelevision.RegisterAVDevice(desktop, "HDMI3");

            //Create a Cable Box and register it to the television
            CableBox cableBox = new CableBox("Spectrum Cable Box: Living Room", AVConnection.AVConnectionType.Component);
            myTelevision.RegisterAVDevice(cableBox, "Comp (YPbPr)");

            Console.WriteLine();
            Console.WriteLine();

            //Power on Cable Box
            cableBox.TogglePowerOnState();

            Console.WriteLine();
            Console.WriteLine();

            //List all attached devices
            Console.WriteLine("All devices attached to TV: ");

            foreach (AudioVideoDevice device in myTelevision.RegisteredAVDevices.Values)
            {
                Console.WriteLine(device.Name);
            }

            Console.WriteLine();
            Console.WriteLine();

            //Open Store and Netflix on all attached devices
            foreach (AudioVideoDevice device in myTelevision.RegisteredAVDevices.Values)
            {
                Console.WriteLine(device.Name + "-->");
                device.OpenStoreApplication();
                device.OpenNetflix();
                Console.WriteLine();
            }

            Console.WriteLine();

            //Toggle power on state on all attached devices
            foreach (AudioVideoDevice device in myTelevision.RegisteredAVDevices.Values)
            {
                device.TogglePowerOnState();
            }
        }
    }
}