using System;
using System.Security.Cryptography;
using System.Text;
using TicTacToe.Core.Services;

namespace TicTacToe.BLL
{
    public class HashService : IHashService
    {
        public string GetHash(string value)
        {
            using (var hashAlgorithm = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(value);
                byte[] passwordHashBytes = hashAlgorithm.ComputeHash(passwordBytes);
                return Convert.ToBase64String(passwordHashBytes);
            }
        }
    }
}
