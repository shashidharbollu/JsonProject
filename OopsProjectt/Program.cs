using System;

namespace OopsProjectt.InventoryDataManagement
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to inventory");
            const string Inventory_Path = @"C:\oops programme\JsonProject\OopsProjectt\InventoryDataManagement\Inventory.json";
            inventorymanagement data = new inventorymanagement();
            Console.WriteLine("Display 1\n");
            bool check = true;
            while (check)
            { 
            Console.WriteLine("Enter your option to execute: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        data.DisplayInventory(Inventory_Path);
                        break;
                        case 2:
                        check = false;
                        break;
                }
            }
        }
    
    }

}