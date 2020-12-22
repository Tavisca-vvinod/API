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
            //in this method, check if the item id is 0, if it is zero, then set response.status as failure and description as missing or null item id
            //if the id provided in request is invalid (if such an id is not present in the list), data layer will return null, in such case set status as failure and description as invalid item id
            //in success scenario, set reponse.status as success and return the response
            
            var item = ItemDataLayer.GetItemById(id);
            var response = new GetItemsResponse();
            response.Items = new List<Item>();
            response.Items.Add(item);
            return response;
        }
    }
}
