using System;
using System.Collections.Generic;

namespace BankingApp.Models
{
    public partial class Account
    {
        public Account()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int AccountId { get; set; }
        public int UserId { get; set; }
        public decimal? Balance { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
