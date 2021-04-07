using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using System.IO;

namespace Data
{
    public class TokenDataLayer
    {
        //public string generateAndSaveToken
        public static string GenerateAndSaveToken()
        {
            Guid obj = Guid.NewGuid();
            
            File.AppendAllLines("C:\\Users\\Havock\\RiderProjects\\API2\\Data\\Token.txt", new String[] { obj.ToString() });
            return obj.ToString();

            
        }
    }
}
