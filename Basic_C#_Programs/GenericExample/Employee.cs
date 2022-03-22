using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExample
{
    public class Employee<T>
    {
        public List<T> things;

        public Employee()
        {
            things = new List<T>();
        }

        public void AddProperty(T newProperty)
        {
            things.Add(newProperty);
        }

        public void PrintAllThings()
        {
            foreach (var thing in things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
