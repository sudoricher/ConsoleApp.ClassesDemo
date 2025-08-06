using System;

namespace ConsoleApp.ClassesDemo
{
    public class Person
    {
        public string name;
        public int age;

        public void introduce()
        {
            Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
        }
    }
    
}
