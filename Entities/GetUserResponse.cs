using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class GetUserResponse : Response
    {
        public List<User> users { get; set; }
    }
}
