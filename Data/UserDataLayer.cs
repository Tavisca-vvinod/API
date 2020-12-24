using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using System.IO;

namespace Data
{
    public class UserDataLayer
    {
        public static bool AddUser(User user)
        {
            string path = "C:\\Users\\Havock\\RiderProjects\\API2\\Data\\AddedUsers.txt";

            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(user.UserEmailId + "," + user.UserPhone + "," + user.UserName + "," + user.UserAge);
            writer.Close();

            return true;

        }
    }
}
