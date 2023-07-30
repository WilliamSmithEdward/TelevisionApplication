namespace TelevisionApplication
{
    internal class RemoteControlButton
    {
        public Action Action { get; private set; }

        public RemoteControlButton(Action action)
        {
            Action = action;
        }
    }
}
