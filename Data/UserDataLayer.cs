using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using System.IO;

namespace Data
{
    public class UserDataLayer
    {
        //1. GetUserFromFile() - only read and return the list of users
        //2. AddUser() - call the first method , do validations. if okay. then add line by line
        
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
                reader.Close();
            }


            StreamWriter writer = new StreamWriter("C:\\Users\\Havock\\RiderProjects\\API2\\Data\\Users.txt", true);
            writer.WriteLine(user.EmailId + "#," + user.Phone + "," + user.Name);
            writer.Close();

            //check if email id exists: return false

            return true;

        }
    }
}
