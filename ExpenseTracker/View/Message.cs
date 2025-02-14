using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.View
{
    public static class Message
    {
        
        public static void Menu()
        {
            Console.Write("=== ExpenseTracker - Sistema de Seguimiento de Gastos ===\r\n" +
                "1. Agregar un nuevo gasto\r\n" +
                "2. Listar todos los gastos\r\n" +
                "3. Calcular gasto por año\r\n" +
                "4. Calcular gastos por mes\r\n" +
                "5. Eliminar un gasto\r\n" +
                "6. Salir\r\n\r\n" +
                "Seleccione una opción:");
        }

        //Usar en le caso 1
        public static void TituloGasto()
        {
            Console.Write("\n" +
                "=== Agregar un nuevo gasto ===\r\n");
        }
        public static void AgregarDescripcion()
        {
            Console.Write("Ingresa la descripción del gasto: ");
        }
        public static void AgregarMonto()
        {
            Console.Write("Ingresa el monto total: ");
        }

        //Usar en caso 2

        public static void LitadoGastos()
        {
            Console.WriteLine("Lista de gastos.");
        }

        //Caso 3
        public static void GastosTotalesAño()
        {
            Console.Write("Gasto anual: ");
        }

        //Caso 4
        public static void GastosTotalesMes()
        {
            Console.Write("Gasto del mes: ");
        }

        //Caso 5
        public static void GastoEliminado()
        {
            Console.WriteLine("Se elimino el gasto.");
        }

        //Caso 6
        public static void Despedida()
        {
            Console.WriteLine("Gracias por usar Expanse Tracker.");
        }
    }
}
