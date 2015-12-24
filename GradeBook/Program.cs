using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        { 

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.1f);
            book.AddGrade(75);
            book.NameChanged += OnNameChanged;
            book.Name = "Diego GradeBook";
            book.Name = "Alan GradeBook";
            bool isAmerican = book.Name == "Scott Gradebook" ? true : false;
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Results", stats.AverageGrade);
            //WriteResult("Highest", (int)stats.HighestGrade);
            //WriteResult("Lowest", stats.LowestGrade);
            Console.ReadKey();
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Gradebook changing name from {args.ExistingName} to {args.NewName}");
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
          
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine("{0}: {1}",description,result);
        }
    }
}
