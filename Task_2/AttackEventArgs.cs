namespace Task_2
{
    internal class AttackEventArgs : EventArgs
    {
        public string Message { get; }
        public AttackEventArgs(string message)
        {
            Message = message;
        }
    }
}
