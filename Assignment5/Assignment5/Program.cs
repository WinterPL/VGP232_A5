using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure of Assignment 5!");
            Inventory inv= new Inventory(10);
            Console.WriteLine("Inventory inv with " + inv.AvailableSlots + " space");


            Item blade = new Item("BLADE", 10, ItemGroup.Equipment);
            Console.WriteLine(blade.Name + " x" + blade.Amount+" -"+ blade.Group);
            Item key = new Item("Key", 1,ItemGroup.Consumable);
            Console.WriteLine(key.Name + " x" + key.Amount + " -"+ key.Group);

            inv.AddItem(blade);
            inv.AddItem(key);

            Console.WriteLine(inv.AvailableSlots);

            // TODO: Create an inventory
            // TODO: Add 2 items to the inventory
            // Verify the number of items in the inventory.
        }
    }
}
