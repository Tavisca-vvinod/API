using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class GetItemsResponse : Response
    {
        public List<Item> Items { get; set; }

    }
}
