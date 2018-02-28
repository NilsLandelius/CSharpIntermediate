using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(String connection)
            :base(connection)
        {
            Console.WriteLine("Got the OracleConnectionString");  
        }

        public override void CloseConnection()
        {
            Console.WriteLine("closing Oracle connection");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening Oracle connection");
        }
    }
}
