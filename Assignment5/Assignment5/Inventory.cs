﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    public class Inventory
    {
        // The dictionary items consist of the item and the quantity
        private Dictionary<Item, int> items = new Dictionary<Item, int>();

        public int AvailableSlots
        {
            get
            {
                return availableSlots;
            }
        }

        public int MaxSlots
        {
            get
            {
                return maxSlots;
            }
        }


        // The available slots to add item, once it's 0, you cannot add any more items.
        private int availableSlots;

        // The max available slots which is set only in the constructor.
        private int maxSlots;
        public Inventory(int slots)
        {
            maxSlots = slots;
            availableSlots = maxSlots;
        }

        /// <summary>
        /// Removes all the items, and restore the original number of slots.
        /// </summary>
        public void Reset()
        {
            items.Clear();
            availableSlots = maxSlots;
        }

        /// <summary>
        /// Removes the item from the items dictionary if the count is 1 otherwise decrease the quantity.
        /// </summary>
        /// <param name="name">The item name</param>
        /// <param name="found">The item if found</param>
        /// <returns>True if you find the item, and false if it does not exist.</returns>
        public bool TakeItem(string name, out Item found)
        {
            found = null;
            foreach(var i in items)
            {
                if(i.Key.Name == name)
                {
                    found = i.Key;
                    if(items[i.Key] == 1)
                    {
                        items.Remove(i.Key);
                        availableSlots += 1;
                    }
                    else
                    {
                    items[i.Key] -= 1;
                    }
                
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Checks if there is space for a unique item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AddItem(Item item)
        {

            if(availableSlots > 0)
            {
                foreach (KeyValuePair<Item, int> i in items)
                {
                    if (i.Key.Name == item.Name)
                    {
                        ++items[i.Key];
                        return true;
                    }
                }
                items.Add(item, 1);
                availableSlots -= 1;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Iterates through the dictionary and create a list of all the items.
        /// </summary>
        /// <returns></returns>
        public List<Item> ListAllItems()
        {
            List<Item> itemlist = new List<Item>();
            // use a foreach loop to iterate through the key value pairs and duplicate the item base on the quantity.
            foreach (KeyValuePair<Item, int> i in items)
            {
                itemlist.Add(i.Key);
            }
            return itemlist;
        }
    }
}
