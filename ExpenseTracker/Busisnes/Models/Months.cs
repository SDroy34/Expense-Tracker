using ExpenseTracker.Busisnes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Busisnes.Models
{
    internal class Months : IMonths
    {
        public Int16? IdMonth { get; set; }
        public string Month { get; set; }
        public decimal? Presupuesto { get; set; }
    }
}
