using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegateTutorial.Classes;

namespace DelegateTutorial.Interface
{
    internal interface IInventory
    {
        void RemoveItem(string id);
        void AddItem(Item item);
        void ClearInventory();
        Item GetItem(string id);
        IDictionary<string, InventoryItem> GetInventoryList();
        void ChangeItemAmount(string itemId, int newAmount);
    }
}
