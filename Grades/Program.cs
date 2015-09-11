using System;
using System.Collections.Generic;


namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.1f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("Average: " + stats.AverageGrade);
            Console.WriteLine("Highest: " + stats.HighestGrade);
            Console.WriteLine("Lowest: " + stats.LowestGrade);

        }
    }
}
