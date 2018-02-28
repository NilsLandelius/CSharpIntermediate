using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    public class DbCommand
    {
        private String _command { get; set; }
        public DbConnection Connection { get; set; }

        public DbCommand(DbConnection connection, String command)
        {
            if (command == null || command == "")
                throw new InvalidOperationException();
            else
            this._command = command;
            this.Connection = connection;
            
        }
        public void Execute()
        {
            Console.WriteLine("Exectuing command:{0}", this._command);
        }
    }
}
