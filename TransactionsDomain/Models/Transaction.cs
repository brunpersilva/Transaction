using System;
using System.Collections.Generic;
using System.Text;
using TransactionsDomain.Models.Enuns;

namespace TransactionsDomain.Models
{
    public class Transaction
    {
        public string TransactionCode { get; set; }
        public User User { get; set; }
        public decimal Value { get; set; }
        public OrderType OrderType { get; set; }       
        public TransactionStatus Status { get; set; }
        public DateTime Date { get; set; }
    }
}
