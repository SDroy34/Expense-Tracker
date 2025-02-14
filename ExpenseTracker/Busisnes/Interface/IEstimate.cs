using ExpenseTracker.Busisnes.Models;
using Org.BouncyCastle.Asn1.X9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Busisnes.Interface
{
    public interface IEstimate
    {
        int IdMonto { get; set; }
        decimal? Monto { get; set; }
        DateTime FechaCreacionMonto { get; set; }
        string Descripcion { get; set; }
        Int16? Mes { get; set; }

    }
}
