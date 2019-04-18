using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class Workflow
    {
        private List<IActivity> _steps;

        public Workflow()
        {
            _steps = new List<IActivity>();
        }

        public void Run()
        {
            foreach (var step in _steps)
            {
                step.Execute();
            }
        }

        public void AddStep(IActivity workflowStep)
        {
            _steps.Add(workflowStep);
        }

        public void RemoveStep(IActivity workflowStep)
        {
            _steps.Remove(workflowStep);
        }

        public List<IActivity> GetSteps()
        {
            return _steps;
        }
    }
}
