using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using System.IO;
using System.Web;
namespace Data

{
    public class UserDataLayer
    {
        
        
        public static List<User> GetUserFromFile()
        {
            List<User> users = new List<User>();


            return users;
        }

        public static bool AddUser(User user)
        {

            StreamReader reader = new StreamReader("C:\\Users\\Havock\\RiderProjects\\API2\\Data\\Users.txt");
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int hashIndex = line.IndexOf("#");
                    string justEmail = line.Substring(0, hashIndex);
                    if (string.Equals(justEmail, user.EmailId))
                    {
                        return false;
                    }
                }
            }

            var encryptedPassword = Utility.Encryption(user.Password);
            StreamWriter writer = new StreamWriter("C:\\Users\\Havock\\RiderProjects\\API2\\Data\\Users.txt", true);
            writer.WriteLine(user.EmailId + "#," + user.Phone + "," + user.Name+','+encryptedPassword);
            writer.Close();

            

            return true;
        }

        public static string ValidateUser(LoginRequest request)
        {
            //Validate ID password
            //if valid,
            //call token data layer.generate GUID method 
        }
    }
}
