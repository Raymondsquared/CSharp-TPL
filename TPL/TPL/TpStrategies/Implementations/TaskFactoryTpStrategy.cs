using System;
using System.Threading;
using System.Threading.Tasks;
using TPL.TpStrategies.Abstractions;

namespace TPL.TpStrategies.Implementations
{
    public class TaskFactoryTpStrategy : ITpStrategy
    {
        public string GetName()
        {
            return "Task.Factory";
        }

        public void Run()
        {
            //Thread.CurrentThread.Name = "Main";

            // Better: Create and start the task in one operation. 
            Task taskA = Task.Factory.StartNew(() => Console.WriteLine("Hello from taskA."));

            // Output a message from the calling thread.
            Console.WriteLine("Hello from thread '{0}'.",Thread.CurrentThread.Name);

            taskA.Wait();
        }
    }
}
