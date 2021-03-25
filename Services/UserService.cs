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
            if (String.IsNullOrEmpty(user.Name) || user.Phone.Length < 10)
            {
                response.Status = KeyStore.Failure;
                response.Description = KeyStore.InvalidDetails;
            }

            var usersFromFile = UserDataLayer.GetUserFromFile();



            try
            {
                bool IsAdded = UserDataLayer.AddUser(user);


                if (IsAdded == true)
                {
                    response.Status = KeyStore.Success;
                    response.Description = KeyStore.UserAdded;
                    return response;
                }
                else
                {
                    response.Status = KeyStore.Failure;
                    response.Description = KeyStore.EmailExists;
                    return response;
                }


            }
            catch (Exception e)
            {
                response.Status = KeyStore.Failure;
                response.Description = KeyStore.UserNotAdded;
                return response;


            }
        }
    }
}