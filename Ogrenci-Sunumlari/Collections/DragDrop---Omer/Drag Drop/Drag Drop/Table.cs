using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drag_Drop
{
    public class Table
    {
        public string Name { get; set; }
        public int ImageIndex { get; set; }
        public ICollection<Addition> Additions { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    public class Addition
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public override string ToString()
        {
            return Name + " - " + Price;
        }
    }
}
