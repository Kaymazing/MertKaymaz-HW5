using MertKaymaz_HW5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MertKaymaz_HW5.Service
{
    public class CetUserService
    {
        private Database db;
        public CetUserService()
        {
            db = new Database();
        }
        public CetUser Login(string UserName, string Password)
        {
            
            string hashedPasword = hashPassword(Password);
            var loginUser = db.CetUsers.FirstOrDefault(u => u.UserName == UserName && u.Password == hashedPasword);

            return loginUser;
        }
        public string hashPassword(string plainPassword)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                var plainBytes = Encoding.UTF8.GetBytes(plainPassword);
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(plainBytes);

                // Convert byte array to a string 
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();

            }
        }
        public bool Insert(CetUser cetUser)
        {
            return true;
        }
    }
}
