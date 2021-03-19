using System;

namespace GarbageCollection
{
    class Program
    {
        static void ShortLives (Person parent)
        {
            Person fred = new Person
            {
                Name = "Fred",
                ChildOne = new Person { Name = "Bamm-Bamm" }
            };

            parent.ChildTwo = fred.ChildOne;
        }

        static void Run()
        {
            Person wilma = new Person 
            { 
                Name = "Wilma",
                ChildOne = new Person { Name = "Pebbles"}
            };

            ShortLives(wilma);

            Console.WriteLine("Leaving 'ShortLives'...");

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        static void Main()
        {
            Run();

            Console.WriteLine("\nLeaving 'Run'...");

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
