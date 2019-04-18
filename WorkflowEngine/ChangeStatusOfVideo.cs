namespace WorkflowEngine
{
    public class ChangeStatusOfVideo : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Change the status of the video record in the database to “Processing”.");
        }
    }
}