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
            Response response = new Response();
            if (String.IsNullOrEmpty(user.UserName) || user.UserPhone.Length < 10)
            {
                response.Status = "Failure";
                response.Description = "Invalid user deatils";
            }

            bool IsAdded = UserDataLayer.AddUser(user);

            
            if(IsAdded == true)
            {
                response.Status = "Success!";
                response.Description = "User added to database";
                return response;
            }
            else
            {
                response.Status = "Failure";
                response.Description = "The user could not be added to the databse";
                return response;
            }


        }



            
    }
}
