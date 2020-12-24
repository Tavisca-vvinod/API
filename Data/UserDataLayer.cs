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
            string filePath = "C:\\Users\\Havock\\RiderProjects\\API2\\Data\\AddedUsers.txt";

            StreamWriter stream = new StreamWriter(filePath, true);

            stream.WriteLine(user.UserEmailId + "," + user.UserPhone + "," + user.UserName + "," + user.UserAge);
            stream.Close();
            return true;
        }
    }
}
