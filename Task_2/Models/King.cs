using System.Xml.Linq;

namespace Task_2
{
    public delegate void KingUnderAttackHandler();
    internal class King
    {
        public event KingUnderAttackHandler UnderAttack;
        public string kingName { get; set; }
        public King(string kingName) {
            this.kingName = kingName;
        }
        public void OnAttack()
        {
            Console.WriteLine($"King {kingName} is under attack!");
            UnderAttack?.Invoke();
        }
    }
}
