using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegateTutorial.Classes;

namespace DelegateTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new[] { new Item("TShirt"), new Item("Pants") };
            IPlayer player1 = new Player(PlayerDied, 100, "Player1");
            player1.GiveItem(items[0]);
            player1.GiveItem(items[1], 3);
            Console.WriteLine(player1.Inventory.ToString());
            player1.IncreaseHealth(-30);
            Console.WriteLine(player1.ToString());
            player1.IncreaseHealth(-80);
            Console.WriteLine(player1.ToString());

        }

        private static void PlayerDied(Player player, string deathTime)
        {
            player.Inventory.ClearInventory();
            Console.WriteLine(player.Name + $" has died ({deathTime})");
            Console.WriteLine(player.Inventory.ToString());
        }
    }
}
