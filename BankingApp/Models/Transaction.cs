using System;
using System.Collections.Generic;

namespace BankingApp.Models
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Account Account { get; set; }
    }
}
