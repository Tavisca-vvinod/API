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
            var items = ItemDataLayer.GetItemsList();
            var response = new GetItemsResponse();
            response.Items = items;
            return response;
        }

        public static Item GetItemById(int id)
        {
            var items = ItemDataLayer.GetItemById(id);
            return items;
        }
    }
}
