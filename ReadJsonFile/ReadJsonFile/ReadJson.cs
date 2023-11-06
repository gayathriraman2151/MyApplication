using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadJsonFile
{
    public class ReadJsonObject
    {
        public class MainObject
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Type { get; set; }
            
            public Inventory InventoryItem {  get; set; } 

            public class Inventory
            {
                public float Price { get; set; }
                public int Quantity { get; set; }

            }
        }
    }
}
