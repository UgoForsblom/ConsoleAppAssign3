using System;
using _3ConsoleApp.Test.modell;

namespace _3ConsoleAppAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("PEter", "jdjdndj");
            Console.WriteLine(person.GetFullName());
            person.Firstname = "HeJo";
            Console.WriteLine(person.Firstname);

           
        }
    }
}
