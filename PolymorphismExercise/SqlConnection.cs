using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(String connection) : base(connection)
        {
            Console.WriteLine("Got the Sql ConnectionString");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing a Sql Connection");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening a Sql Connection");
        }

        public override void Timeouttime()
        {
            Console.WriteLine("Sql timed out");
        }
    }
}
