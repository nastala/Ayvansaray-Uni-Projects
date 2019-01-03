using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegateTutorial.Interface;

namespace DelegateTutorial.Classes
{
    internal struct InventoryItem
    {
        public InventoryItem(Item item, int amount)
        {
            Item = item;
            Amount = amount;
        }

        public Item Item { get; set; }
        public int Amount { get; set; }
        public override string ToString()
        {
            return Item.Name + " : " + Amount;
        }
    }
    internal class Inventory : IInventory
    {
        private readonly IDictionary<string, InventoryItem> _inventoryItems;

        public Inventory()
        {
            _inventoryItems = new Dictionary<string, InventoryItem>();
        }
        public void RemoveItem(string id)
        {
            _inventoryItems.Remove(id);
        }

        public void AddItem(Item item)
        {
            _inventoryItems.Add(item.Id, new InventoryItem(item, 1));
        }

        public void ClearInventory()
        {
            _inventoryItems.Clear();
        }

        public Item GetItem(string id)
        {
            return _inventoryItems[id].Item;
        }

        public IDictionary<string, InventoryItem> GetInventoryList()
        {
            return _inventoryItems;
        }

        public void ChangeItemAmount(string itemId, int newAmount)
        {
            var inventoryItem = _inventoryItems[itemId];
            inventoryItem.Amount = newAmount;
            _inventoryItems[itemId] = inventoryItem;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("Player Inventory\n");
            if (_inventoryItems.Count == 0)
            {
                sb.AppendLine("Is Empty");
                return sb.ToString();
            }
            foreach (var item in _inventoryItems)
            {
                for (int i = 0; i < item.Value.Amount; i++)
                {
                    sb.AppendLine(item.Value.Item.Name);
                }
            }

            return sb.ToString();
        }
    }
}
