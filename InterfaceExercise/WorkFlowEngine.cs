using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class WorkFlowEngine
    {
        private IWorkFlow _workflow;

        public WorkFlowEngine(IWorkFlow workflow)
        {
            this._workflow = workflow;
        }

        public void Run()
        {
            _workflow.Execute();
        }
        
    }
}
