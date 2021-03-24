using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User
    {
        public string EmailId { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        public static implicit operator string(User v)
        {
            throw new NotImplementedException();
        }
    }
}
