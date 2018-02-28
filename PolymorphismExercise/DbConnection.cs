using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    public abstract class DbConnection
    {
        private string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(String connection)
        {
            if (connection == null || connection == "")
                throw new InvalidOperationException();
        }
        public abstract void OpenConnection();

        public abstract void CloseConnection();

        public virtual void Timeouttime()
        {
            Console.WriteLine("No timeout set");
        }
    }
}
