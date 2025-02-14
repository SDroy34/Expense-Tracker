using ExpenseTracker.Busisnes.Models;
using ExpenseTracker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var moneyMinder = new MoneyMinderLogic();
            moneyMinder.RunProgram();
        }
    }
}
