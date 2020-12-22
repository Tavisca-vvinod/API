using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class ItemDataLayer
    {
        public static List<Item> ItemsList = new List<Item>()
        {
            new Item()
            {
                ItemId = 1,
                ItemName= "Pen",
                Price = 9.0M
            },
            new Item()
            {
                ItemId = 2,
                ItemName= "Book",
                Price = 23.0M
            },
            new Item()
            {
                ItemId = 3,
                ItemName= "StickyNotes",
                Price = 289.0M
            }
        };

        public static List<Item> GetItemsList()
        {
            return ItemsList;
        }

        public static Item GetItemById(int itemId)
        {
            return ItemsList.Find(x => x.ItemId == itemId);
        }
    }
}
