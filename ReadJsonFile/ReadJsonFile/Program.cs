using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ReadJsonFile
{
    public class Program
    {
        static void Main(string[] args)
        {
            string jsonString =
@"{
   ""Name"": ""Milk"",
    ""Description"": ""Dairy Product"",
    ""Type"": ""Grocery"",
    ""InventoryItem"":{
        ""Price"": 2.49,
        ""Quantity"": 2
    }
    
}
";
            ReadJsonObject.MainObject data = JsonConvert.DeserializeObject<ReadJsonObject.MainObject>(jsonString);

            Console.WriteLine("Read Json Grocery Items ");
            Console.WriteLine();
            Console.WriteLine("Name: " + data.Name);
            Console.WriteLine("Description: " + data.Description);
            Console.WriteLine("Type: " + data.Type);
            Console.WriteLine();
            Console.WriteLine("Inventory");
            Console.WriteLine("Price: " + data.InventoryItem.Price);
            Console.WriteLine("Quantity: " + data.InventoryItem.Quantity);

        }
            
    }
}
