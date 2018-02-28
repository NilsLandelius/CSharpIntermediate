using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbCommand = new DbCommand(new OracleConnection("SqlConnection"),"This is the command");
            dbCommand.Connection.OpenConnection();
            dbCommand.Execute();
            dbCommand.Connection.CloseConnection();

            Console.ReadLine();
        }
    }
}
