using System;
using System.Collections.Generic;
using System.Threading;
using TPL.TpStrategies.Abstractions;
using TPL.TpStrategies.Implementations;

namespace TPL
{
    public class Program
    {
        private static readonly IEnumerable<ITpStrategy> _tpStrategies = new List<ITpStrategy>()
        {
            new TaskStartTpStrategy(),
            new TaskRunTpStrategy(),
            new TaskFactoryTpStrategy(),
            new TaskTTpStrategy(),
            new TaskLambdaDelegateIncorrectStrategy(),
            new TaskLambdaDelegateCorrectStrategy()
        };
        
        public static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main";

            foreach (var tpStrategy in _tpStrategies)
            {
                Console.WriteLine($"\nrunning  {tpStrategy.GetName()} : ");
                tpStrategy.Run();
            }
         }
    }
}
