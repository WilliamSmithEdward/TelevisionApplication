namespace TelevisionApplication
{
    internal class PersonalComputer : AudioVideoDevice
    {
        public string DefaultBrowserName { get; set; }

        public PersonalComputer(string name, AVConnection.AVConnectionType avConnectionType, string defaultBrowserName)
            : base(name, avConnectionType) 
        {
            DefaultBrowserName = defaultBrowserName;
        }

        public override void OpenStoreApplication()
        {
            Console.WriteLine("Opening the Microsoft Store.");
        }

        public override void OpenNetflix()
        {
            Console.WriteLine("Opening Netflix on your default browser (" + DefaultBrowserName + ").");
        }
    }
}
