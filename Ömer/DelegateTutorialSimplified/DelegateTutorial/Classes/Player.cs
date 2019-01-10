using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTutorial.Classes
{
    internal class Player
    {
        public int HP { get; private set; }
        public string Name { get; set; }
        public event Action<Player> PlayerDied;


        public Player(Action<Player> deathEvent, int hp, string playerName)
        {
            PlayerDied += deathEvent;
            Name = playerName;
            HP = hp;
        }

        private void CheckDeathStatus()
        {
            if (HP <= 0)
            {
                PlayerDied?.Invoke(this);
            }
        }
        public void IncreaseHealth(int amount)
        {
            HP += amount;
            Console.WriteLine(Name + " : Increased HP by " + amount + "\n" + this);
            CheckDeathStatus();
        }
        public override string ToString()
        {
            return Name + " : " + HP +" "+ nameof(HP);
        }
    }
}
