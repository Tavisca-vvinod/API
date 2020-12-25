using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data
{
    public class ItemDataLayer
    {
        
        public static Item GetItemById(int itemId)
        {
            List<Item> ItemsList = GetAvailableItems();
            return ItemsList.Find(x => x.ItemId == itemId);
        }

        public static List<Item> GetAvailableItems()
        {
            List<Item> items = new List<Item>();

              
            StreamReader sr = new StreamReader("C:\\Host\\Data\\AvailableItems.txt");

            
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

             
            string str = sr.ReadLine();

             
            while (str != null)
            {
                string[] itemFields = str.Split(',');
                items.Add(
                    new Item()
                    {
                        ItemId = int.Parse(itemFields[0]),
                        ItemName = itemFields[1],
                        Price = decimal.Parse(itemFields[2])
                    });
                str = sr.ReadLine();
            }

             
            sr.Close();

            return items;
        }
    }
}
