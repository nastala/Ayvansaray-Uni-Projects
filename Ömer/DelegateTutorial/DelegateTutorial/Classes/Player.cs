using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegateTutorial.Interface;

namespace DelegateTutorial.Classes
{
    internal class Player : IPlayer
    {
        public int HP { get; private set; }
        public string Name { get; set; }
        public IInventory Inventory { get; private set; }
        public event Action<Player, string> PlayerDied;

        private readonly GameTimer _timer;

        public Player(Action<Player, string> deathEvent, int hp, string playerName)
        {
            _timer = new GameTimer();
            _timer.StartTimer();
            PlayerDied += deathEvent;
            Name = playerName;
            HP = hp;
            Inventory = new Inventory();
        }

        private void CheckDeathStatus()
        {
            if (HP <= 0)
            {
                PlayerDied?.Invoke(this, _timer.StopTimer());
            }
        }
        public void IncreaseHealth(int amount)
        {
            Console.WriteLine(Name + " : Increased HP by " + amount);
            HP += amount;
            CheckDeathStatus();
        }

        public void GiveItem(Item item)
        {
            Inventory.AddItem(item);
        }

        public void GiveItem(Item item, int amount)
        {
            Inventory.AddItem(item);
            Inventory.ChangeItemAmount(item.Id, amount);
        }

        public override string ToString()
        {
            return Name + " : " + HP +" "+ nameof(HP);
        }
    }
}
