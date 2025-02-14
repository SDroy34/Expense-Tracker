using ExpenseTracker.Busisnes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Busisnes.Models
{
    public class Estimate : IEstimate
    {
        public int IdMonto { get; set; }
        public decimal? Monto { get; set; }
        public DateTime FechaCreacionMonto { get; set; }
        public string Descripcion { get; set; }
        public Int16? Mes {  get; set; }
    }
}
