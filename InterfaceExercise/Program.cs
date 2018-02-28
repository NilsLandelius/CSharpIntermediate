using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataflow = new DataWorkFlow();
            //dataflow.steps.add("start the sequence");
            //dataflow.steps.add("read the data");
            //dataflow.steps.add("compile it");
            //dataflow.steps.add("check results");

            var WorkEngine = new WorkFlowEngine(dataflow);
            WorkEngine.Run();
            Console.ReadLine();
        }
    }
}
