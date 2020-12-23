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
                response.Status = "Faliure";
                response.Description = "Store is empty";
                return response;
            }
            response.Items = items;
            response.Status = "success";
            return response;
        }
        
        public static GetItemsResponse GetItemById(int id)
        {
            
            var response = new GetItemsResponse();

            if (id == 0)
            {
                response.Status = "Failure";
                response.Description = "Invalid item id";
                return response;
            }

            var item = ItemDataLayer.GetItemById(id);
            if (item == null)
            {
                response.Status = "Failure";
                response.Description = "Invalid item id";
                return response;
            }
            response.Items = new List<Item>();
            response.Items.Add(item);
            return response;
        }
    }
}
