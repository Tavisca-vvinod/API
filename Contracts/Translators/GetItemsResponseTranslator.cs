using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Translators
{
    public static class GetItemsResponseTranslator
    {
        public static GetItemsResponse ToDataContract(this Entities.GetItemsResponse responseFromService)
        {
            GetItemsResponse response = new GetItemsResponse();
            response.Items = new List<Item>();
            
            if(responseFromService!=null && responseFromService.Items !=null)
            {
                foreach(var item in responseFromService.Items)
                {
                    response.Items.Add(item.ToDataContract());
                }
            }

            return response;
        }
    }
}
