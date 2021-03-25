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
            response.Items = items;
            response.Status = Status.Success;
            return response;
        }

        public static GetItemsResponse GetItemById(int id)
        {

            var response = new GetItemsResponse();

            if (id == 0)
            {
                response.Status = Status.Failure;
                response.Description = KeyStore.InvaildItem;
                return response;
            }

            
            var item = ItemDataLayer.GetItemById(id);
            if (item == null)

            {
                response.Status = Status.Failure;
                response.Description = KeyStore.InvaildItem;
                return response;
            }
            response.Items = new List<Item>();
            response.Items.Add(item);
            return response;
        }

        
    }
}
