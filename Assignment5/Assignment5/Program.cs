using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure of Assignment 5!");
            Inventory inv= new Inventory(10);

            Item blade = new Item("BLADE", 1,ItemGroup.Equipment);
            Item key = new Item("Key", 2,ItemGroup.Consumable);


            // TODO: Create an inventory
            // TODO: Add 2 items to the inventory
            // Verify the number of items in the inventory.
        }
    }
}
