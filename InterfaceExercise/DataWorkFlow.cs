using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class DataWorkFlow : IWorkFlow
    {
        public IList<string> Steps { get; set; }

        public DataWorkFlow()
        {
            Steps = new List<String>();
        }

        public void Execute()
        {
            if (Steps.Count <= 0)
                throw new InvalidOperationException();
            else
            {
                foreach (string Step in Steps)
                {
                    Console.WriteLine(Step);
                }

            }
        }
    }
}
