using System;
using Entities;

namespace Services
{
    public class Utility
    {
        public static Response GetResponse(string status,string description)
        {
            return new Response() { Description = description, Status = status };
        }
    }
}
 