using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OopsProjectt.InventoryDataManagement
{
    public class inventorymanagement
    {
        public void DisplayInventory(string filepath)
        {
            using (StreamReader reader = new StreamReader(filepath))
            { 
            var json = reader.ReadToEnd();
            var inventory = JsonConvert.DeserializeObject<List<InventoryData>>(json);
                Console.WriteLine("Name"+"\t"+"weight"+"\t"+"priceperkg"+"\t"+"totalprice");
                foreach (var data in inventory)
                { 
                Console.WriteLine(data.Name+"\t"+data.Weight+"\t"+data.PricePerKg+"\t\t"+(data.Weight*data.PricePerKg));
                }
            }
        }
    }
}
