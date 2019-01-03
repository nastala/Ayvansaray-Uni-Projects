using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegateTutorial.Classes;

namespace DelegateTutorial.Interface
{
    internal interface IPlayer
    {
        int HP { get;}
        IInventory Inventory { get; }
        string Name { get; set; }
        void IncreaseHealth(int amount);
        void GiveItem(Item item);
        void GiveItem(Item item, int amount);
    }
}
