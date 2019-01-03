using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTutorial.Classes
{
    internal class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Item(string name)
        {
            Name = name;
            Id = Guid.NewGuid().ToString();
        }
    }
}
