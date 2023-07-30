namespace TelevisionApplication
{
    internal class AppleTV : AudioVideoDevice
    {
        public AppleTV(string name, AVConnection.AVConnectionType avConnectionType)
            : base(name, avConnectionType) { }

        public override void OpenStoreApplication()
        {
            Console.WriteLine("Welcome to the Apple TV store!");
        }

        public override void OpenNetflix()
        {
            Console.WriteLine("Welcome to netflix on Apple TV!");
        }
    }
}
