using ExpenseTracker.Busisnes.Models;
using ExpenseTracker.View;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace ExpenseTracker.Services
{
    internal class MoneyMinderLogic
    {
            private DateTime _creacMonto = DateTime.Now;
        public void RunProgram()
        {

            var bdMoney = new DbMoneyMinder("127.0.0.1", "3306", "moneyminder", "root");
            try
            {
                bdMoney.OpenBd();
                int opc;
                decimal monto;
                string descripcion;
                bool conver;
                Message.Menu();
                conver = int.TryParse(Console.ReadLine(), out opc);
                if (conver == false)
                    ValidarDatos.ValidarNumeros(opc);
                switch (opc)
                {
                    case 1:
                        //Agregar un nuevo gasto
                        Message.TituloGasto();
                        Message.AgregarDescripcion();
                        descripcion = Console.ReadLine();
                        Message.AgregarMonto();
                        conver = decimal.TryParse(Console.ReadLine(), out monto);
                        if (conver == false)
                            ValidarDatos.ValidarNumeros(monto);
                        bdMoney.AddEstimate(bdMoney, monto, descripcion);

                        break;
                    case 2:
                        //Listar todos los gastos
                        bdMoney.GetAllEstimate(bdMoney);
                        break;
                    case 3:
                        //Calcular gastos por año
                        break;
                    case 4:
                        //Calcular gastos por mes
                        break;
                    case 6:
                        //Salir
                        break;
                    case 0:
                        Console.WriteLine("Fuera de rango.");
                        break;
                    case 7:
                        Console.WriteLine("Fuera de rango.");
                        break;
                    default:
                        Console.WriteLine("Ingresa un numero valido o numero fuera de rango.");
                        break;
                }
                bdMoney.CloseBd();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
