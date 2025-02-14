using ExpenseTracker.Busisnes.Interface;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using System.Reflection.Emit;

namespace ExpenseTracker.Busisnes.Models
{
    public class DbMoneyMinder : DbConnection, IMonths
    {

        //IMonths
        Int16? IMonths.IdMonth { get; set; }
        string IMonths.Month { get; set; }
        decimal? IMonths.Presupuesto { get; set; }

        public DbMoneyMinder(string server, string port, string dataBase, string user) : base(server, port, dataBase, user)
        {

        }


        public void GetAllEstimate(DbMoneyMinder db)
        {
            string qry = "SELECT * FROM moneyminder.estimete;";
            var result = connection.Query<Estimate>(qry);
            foreach (var res in result)
            {
                Console.WriteLine($"{res.IdMonto}.- {res.Descripcion} Monto:{res.Monto} Fecha:{res.FechaCreacionMonto.ToString(format:"yyyy-MM-dd HH:mm:ss")} Mes:{res.Mes}");
            }

        }
        public void AddEstimate(DbMoneyMinder db, decimal dateMont, string dateDesc)
        {
            string qryInsert = "INSERT INTO moneyminder.estimete(Monto, Descripcion) " +
                "VALUES (@monto, @desc)";
            var resInsert = db.connection.Execute(qryInsert, new
            {
                monto = dateMont,
                desc = dateDesc
            });
        }
    }
}
