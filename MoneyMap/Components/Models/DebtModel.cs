using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMap.Components.Models
{
    internal class DebtModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string DebtSource { get; set; }
        public string Status { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; } = DateTime.Now;
        public bool IsCleared { get; set; }

        
    }
       
            
        
    
}
