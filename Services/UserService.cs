using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class UserService
    {
        public static Response AddUser(User user)
        {
            bool IsAdded = UserDataLayer.AddUser(user);

            Response response = new Response();

            if (IsAdded == true)
            {
                response.Status = "Success!";
                response.Description = "Your user was added to the database!";
                return response;
            }
            else
            {
                response.Status = "Failure";
                response.Description = "Your user could not be added to the database";
                return response;
            }
        }
    }
}
