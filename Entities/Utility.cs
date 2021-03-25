using System;
using Entities;
using System.Security.Cryptography;

namespace Entities
{
    public class Utility
    {
        public static Response GetResponse(Status status, string description)
        {
            return new Response() {Description = description, Status = status};
        }

        public static string Encryption(string toEncrypt)
        {
            
            char[] charArray = toEncrypt.ToCharArray();
            var encryptedString = "";
            foreach (var c in charArray)
            {
                int nextAscii = (int) c + 1;
                var newchar = (char) nextAscii;
                encryptedString = encryptedString + newchar;
            }

            return encryptedString;
        }
        public static string Decryption(string toDecrypt)
        {
            
            char[] charArray = toDecrypt.ToCharArray();
            var decryptedString = "";
            foreach (var c in charArray)
            {
                var ascii = (int) c-1;
                decryptedString = decryptedString + (char) ascii;
            }

            return decryptedString;
        }
        
    }
    
}