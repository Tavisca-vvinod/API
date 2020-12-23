using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ItemService
    {
        public static GetItemsResponse GetItems()
        {

            var items = ItemDataLayer.GetAvailableItems();
            var response = new GetItemsResponse();
            if (items.Count == 0)
            {
                response = (GetItemsResponse)Utility.GetResponse("Faliure", "Store is empty");
                return response;
            }
            response.Items = items;
            response.Status = Status.Success;
            return response;
        }
        
        public static GetItemsResponse GetItemById(int id)
        {

            var response = new GetItemsResponse();

            if (id == 0)
            {
                response = (GetItemsResponse)Utility.GetResponse("Faliure", "Invalid item id");
                return response;
            }

            
            var item = ItemDataLayer.GetItemById(id);
            if (item == null)

            {
                response = (GetItemsResponse)Utility.GetResponse("Faliure", "Invalid item id");
                return response;
            }
            response.Items = new List<Item>();
            response.Items.Add(item);
            return response;
        }

        
    }
}