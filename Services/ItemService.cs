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
            response.Status = "success";
            return response;
        }

        public static GetItemsResponse GetItemById(int id)
        {
            var item = ItemDataLayer.GetItemById(id);
            var response = new GetItemsResponse();
            response.Items = new List<Item>();
            response.Items.Add(item);
            return response;
        }
    }
}
