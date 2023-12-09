namespace Task_2.Models
{
    internal class Footman: Soldier
    {
        public Footman(string name)
            : base(name)
        {
        }

        public override void RespondToAttack()
        {
            Console.WriteLine($"Footman {Name} is panicking!");
        }
    }
}