using System;
using System.Security.Cryptography;
using System.Text;

//  Author:       
//  Date:         
//  Description:  

namespace FileName.Controller
{
    internal class PasswordHash
    {
        public string PasswordEncryption(string password)
        {
            if (string.IsNullOrEmpty(password)) return "Not available";

            using var hasher = SHA256.Create();

            var saltedbody = string.Concat("Extra text to make it harder!", password);
            var hash = hasher.ComputeHash(Encoding.UTF8.GetBytes(saltedbody));

            return Convert.ToBase64String(hash);
        }
    }
}
