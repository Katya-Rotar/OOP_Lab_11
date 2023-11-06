namespace Task_2
{
    internal class RoyalGuard
    {
        public string Name { get; }

        public RoyalGuard(string name)
        {
            Name = name;
        }

        public void RespondToAttack()
        {
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }
    }
}