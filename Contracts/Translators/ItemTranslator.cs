using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Translators
{
    public static class ItemTranslator
    {
        public static Item ToDataContract(this Entities.Item item)
        {
            return new Item()
            {
                ItemId = item.ItemId,
                ItemName = item.ItemName,
                Price = item.Price
            };
        }
    }
}
