using System;
using System.Diagnostics;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("How many hours of sleep did you get last nigth?: ");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Format("Hello {0}",name));   
           
            if(hoursOfSleep > 8)
            {
                Console.WriteLine("You are well rested");
            }
            else
            {
                Console.WriteLine("You need more sleep");
            }

        }
    }
}
