using Task_2.Models;

namespace Task_2
{
    internal class RoyalGuard : Soldier
    {
        public RoyalGuard(string name) : base(name)
        {
        }

        public override void RespondToAttack()
        {
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }
    }
}