namespace Task_2
{
    internal class Footman
    {
        public string Name { get; }

        public Footman(string name)
        {
            Name = name;
        }

        public void RespondToAttack()
        {
            Console.WriteLine($"Footman {Name} is panicking!");
        }
    }
}