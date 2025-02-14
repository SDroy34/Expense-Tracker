using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Busisnes.Models
{
    public static class ValidarDatos
    {
        public static int ValidarNumeros(int op)
        {
            bool band, conver;
            int opc = op;
            do
            {
                Console.Write("Vuelve a ingresar el numero: ");
                conver = int.TryParse(Console.ReadLine(), out opc);
                if (conver == true)
                {
                    band = true;
                }
                else
                {
                    band = false;
                }
            } while (band == false);
            return opc;
        }
        public static decimal ValidarNumeros(decimal op)
        {
            bool band, conver;
            decimal opc = op;
            do
            {
                Console.Write("Vuelve a ingresar el numero: ");
                conver = decimal.TryParse(Console.ReadLine(), out opc);
                if (conver == true)
                {
                    band = true;
                }
                else
                {
                    band = false;
                }
            } while (band == false);
            return opc;
        }
    }
}
