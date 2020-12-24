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
            string path = "insert local file path here";

            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(user.UserEmailId + "," + user.UserPhone + "," + user.UserName + "," + user.UserAge);
            writer.Close();

            return true;

        }
    }
}
