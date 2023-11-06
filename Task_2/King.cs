using System.Xml.Linq;

namespace Task_2
{
    internal class King
    {
        public string kingName { get; set; }
        public King(string kingName) {
            this.kingName = kingName;
        }

        public delegate void EventHandler();
        public event EventHandler<AttackEventArgs> AttackEvent;
        public void RespondToAttack() {
            AttackEvent?.Invoke(this, new AttackEventArgs($"King {kingName} is under attack!"));
        }
    }
}
