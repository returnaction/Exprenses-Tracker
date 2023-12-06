﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exprenses_Tracker.Data
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        // nav props
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
