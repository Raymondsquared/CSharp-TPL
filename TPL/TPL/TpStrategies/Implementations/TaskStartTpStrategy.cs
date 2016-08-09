using System;
using System.Threading;
using System.Threading.Tasks;
using TPL.TpStrategies.Abstractions;

namespace TPL.TpStrategies.Implementations
{
    public class TaskStartTpStrategy : ITpStrategy
    {
        public string GetName()
        {
            return "Task.Start";
        }
        public void Run()
        {
            //Thread.CurrentThread.Name = "Main";

            // Create a task and supply a user delegate by using a lambda expression. 
            Task taskA = new Task(() => Console.WriteLine("Hello from taskA."));
            // Start the task.
            taskA.Start();

            // Output a message from the calling thread.
            Console.WriteLine("Hello from thread '{0}'.", Thread.CurrentThread.Name);

            taskA.Wait();
        }
    }
}
