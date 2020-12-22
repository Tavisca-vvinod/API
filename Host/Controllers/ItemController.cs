using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Contracts.Translators;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        // GET api/items
        [HttpGet]
        public GetItemsResponse GetItems()
        {
            var responseFromService = ItemService.GetItems();
            return responseFromService.ToDataContract();
        }

        //GET api/items/itemId
        [HttpGet("{id}")]
        public Item GetItemByItemId(int id)
        {
            var responseFromService = ItemService.GetItemById(id);
            return responseFromService.ToDataContract();
        }
    }
}
