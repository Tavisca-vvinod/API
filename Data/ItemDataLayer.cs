using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data
{
    public class ItemDataLayer
    {
        //public static bool AddUser(User user)
        public static Item GetItemById(int itemId)
        {
            List<Item> ItemsList = GetAvailableItems();
            return ItemsList.Find(x => x.ItemId == itemId);
        }

        public static List<Item> GetAvailableItems()
        {
            List<Item> items = new List<Item>();

            // Takinga a new input stream i.e.  
            StreamReader sr = new StreamReader("C:\\Host\\Data\\AvailableItems.txt");

            // This is use to specify from where  
            // to start reading input stream 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            // To read line from input stream 
            string str = sr.ReadLine();

            // To read the whole file line by line 
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

            // to close the stream 
            sr.Close();

            return items;
        }
    }
}
