using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creat workflow
            var videoEncodingWorkFlow = new Workflow();
            //add steps of the workflow
            videoEncodingWorkFlow.AddStep(new UploadVideo());
            videoEncodingWorkFlow.AddStep(new CallWebService());
            videoEncodingWorkFlow.AddStep(new SendEmail());
            videoEncodingWorkFlow.AddStep(new ChangeStatusOfVideo());
            //Run workflow           
            videoEncodingWorkFlow.Run();
            
        }
    }
}
