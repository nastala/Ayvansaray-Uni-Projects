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
            Player player1 = new Player(PlayerDied, 100, "Player1");
            Player player2 = new Player(PlayerDied, 100, "Player2");
            player1.IncreaseHealth(-30);
            player2.IncreaseHealth(-100);
            player1.IncreaseHealth(-80);
            Console.ReadKey();
        }

        private static void PlayerDied(Player player)
        {
            Console.WriteLine(player.Name + $" has died");
        }
    }
}
