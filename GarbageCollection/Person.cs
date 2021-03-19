using System;

namespace GarbageCollection
{
    public class Person
    {
        public string Name { get; set; }
        public Person ChildOne { get; set; }
        public Person ChildTwo { get; set; }

        ~Person()
        {
            Console.WriteLine($"   Collecting {Name}.");
        }
    }
}
