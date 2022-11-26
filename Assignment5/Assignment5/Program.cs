using System;
using System.Collections.Generic;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure of Assignment 5!");


            Character hero = new Character("Bob", RaceCategory.Human, 100);

            Console.WriteLine("{0} has entered the forest", hero.Name);

            string monster = "goblin";
            int damage = 10;

            Console.WriteLine("A {0} appeared and attacks {1}", monster, hero.Name);

            Console.WriteLine("{0} takes {1} damage", hero.Name, damage);

            hero.TakeDamage(damage);
            Console.WriteLine(hero);

            Console.WriteLine("{0} flees from the enemy", hero.Name);

            string item = "small health potion";
            int restoreAmount = 10;

            Console.WriteLine("{0} find a {1} and drinks it", hero.Name, item);

            Console.WriteLine("{0} restores {1} health", hero.Name, restoreAmount);

            hero.RestoreHealth(restoreAmount);

            Console.WriteLine(hero);

            if (hero.IsAlive)
            {
                Console.WriteLine("Congratulations! {0} survived.", hero.Name);
            }
            else
            {
                Console.WriteLine("{0} has died.", hero.Name);
            }

            Console.WriteLine("\n\n");

            Inventory inv= new Inventory(10);
            Console.WriteLine("Inventory inv with " + inv.AvailableSlots + " space");


            Item blade = new Item("BLADE", 10, ItemGroup.Equipment);
            Console.WriteLine(blade.Name + " x" + blade.Amount+" -"+ blade.Group);
            Item key = new Item("KEY", 1,ItemGroup.Consumable);
            Console.WriteLine(key.Name + " x" + key.Amount + " -"+ key.Group);

            inv.AddItem(blade);
            inv.AddItem(blade);
            inv.AddItem(key);

            Console.WriteLine("Available slot: " + inv.AvailableSlots);

            Item nothing = new Item("nothing",1,ItemGroup.Consumable);
            //Item nothing2 = new Item("nothing",1,ItemGroup.Consumable);
            inv.TakeItem("BLADE",out nothing);
            //inv.TakeItem("KEY",out nothing2);

            Console.WriteLine("take out :" + nothing.Name + " x" + nothing.Amount + " -" + nothing.Group);
            //Console.WriteLine("take out :" + nothing2.Name + " x" + nothing2.Amount + " -" + nothing2.Group);

            Console.WriteLine("Available slot: " + inv.AvailableSlots);

            List<Item> Ilist = inv.ListAllItems();
            foreach(var i in Ilist)
            {
                Console.WriteLine(i.Name + " x" + i.Amount + " -" + i.Group);
            }


        }
    }
}
