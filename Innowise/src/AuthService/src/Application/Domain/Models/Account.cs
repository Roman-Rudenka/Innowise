using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    internal class Account
    {
        public string Id { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string ConfirmPassword { get; set; }
        

        public Account(string email, string password, string confirmPassword)
        {
            Id = Guid.NewGuid().ToString();
            Email = email;
            Password = password;
            ConfirmPassword = confirmPassword;
        }
    }
}
