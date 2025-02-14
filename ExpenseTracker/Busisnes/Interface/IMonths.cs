using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Busisnes.Interface
{
    public interface IMonths
    {
        Int16? IdMonth { get; set; }
        string Month { get; set; }

        decimal? Presupuesto { get; set; }
    }
}
