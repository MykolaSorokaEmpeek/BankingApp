using System;
using System.Collections.Generic;

namespace BankingApp.Models
{
    public partial class User
    {
        public User()
        {
            Account = new HashSet<Account>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Account> Account { get; set; }
    }
}
