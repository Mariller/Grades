using System;
using System.Collections.Generic;
using System.Speech.Synthesis;


namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook("Delan's Book");
            book.AddGrade(91);
            book.AddGrade(89.1f);
            book.AddGrade(75f);
            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("Average: " + stats.AverageGrade);
            Console.WriteLine("Highest: " + stats.HighestGrade);
            Console.WriteLine("Lowest: " + stats.LowestGrade);
            Console.WriteLine("{0}, {1}", stats.LetterGrade, stats.Description);

        }
    }
}
