using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMap.Components.Models
{
    public class TransactionModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public string Tags { get; set; }
        public string Notes { get; set; }
    }
}