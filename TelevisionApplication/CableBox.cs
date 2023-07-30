namespace TelevisionApplication
{
    internal class CableBox : AudioVideoDevice
    {
        public CableBox(string name, AVConnection.AVConnectionType avConnectionType)
            : base(name, avConnectionType) { }

        public override void OpenStoreApplication()
        {
            Console.WriteLine("Welcome to the cablebox store!");
        }
    }
}
