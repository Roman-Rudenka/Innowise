using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    internal class RefreshToken
    {
        public Guid Id { get; set; }
        public string Token { get; set; }
        private DateTime CreatedAt { get; set; }
        private DateTime LifeTime { get; set; }
        
        public Guid AccountId;
        

        RefreshToken(Guid accountId)
        {
            Id = Guid.NewGuid();
            Token = Guid.NewGuid().ToString(); 
            CreatedAt = DateTime.Now;
            LifeTime = CreatedAt.AddDays(30);
            AccountId = accountId;
        }

    }
}
