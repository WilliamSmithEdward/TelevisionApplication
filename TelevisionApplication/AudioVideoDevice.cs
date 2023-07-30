namespace TelevisionApplication
{
    internal abstract class AudioVideoDevice
    {
        public bool PowerOnState { get; private set; }
        public string Name { get; private set; }
        public AVConnection.AVConnectionType AVConnectionType { get; private set; }
        public Television RegisteredTelevision { get; private set; }

        public AudioVideoDevice(string name, AVConnection.AVConnectionType avConnectionType)
        {
            PowerOnState = false;
            Name = name;
            AVConnectionType = avConnectionType;
        }

        public bool RegisterTelevision(Television television, string avInputKey)
        {
            if (television != null)
            {
                if (television.AVInputConnections.Values.Contains(AVConnectionType))
                {
                    if (television.AVInputConnections.Any(x => x.Key.Contains(avInputKey)))
                    {
                        television.RegisteredAVDevices.Add(avInputKey, this);
                        Console.WriteLine(Name + " is now registered with the " + television.Model + " television.");
                        return true;
                    }

                    else
                    {
                        Console.WriteLine("Input named " + avInputKey + " does not exist for this television.");
                        return false;
                    }
                }

                else
                {
                    Console.WriteLine("ERROR! Unable to connect " + Name + ", the television does not support connection type: " + AVConnectionType);
                    return false;
                }
            }

            else
            {
                return false;
            }
        }

        public void TogglePowerOnState()
        {
            PowerOnState = !PowerOnState;

            Console.WriteLine(Name + " is now " + (PowerOnState ? "on" : "off") + ".");
        }

        public abstract void OpenStoreApplication();

        public virtual void OpenNetflix()
        {
            Console.WriteLine("Sorry, this device does not support Netflix.");
        }
    }
}
