using System;
using System.Threading;
using System.Threading.Tasks;
using TPL.TpStrategies.Abstractions;

namespace TPL.TpStrategies.Implementations
{
    public class TaskRunTpStrategy : ITpStrategy
    {
        public string GetName()
        {
            return "Task.Run";
        }
        public void Run()
        {
            //Thread.CurrentThread.Name = "Main";

            // Define and run the task.
            Task taskA = Task.Run(() => Console.WriteLine("Hello from taskA."));

            // Output a message from the calling thread.
            Console.WriteLine("Hello from thread '{0}'.",Thread.CurrentThread.Name);

            taskA.Wait();
        }
    }
}
