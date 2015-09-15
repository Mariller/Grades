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

            try
            {

                Console.WriteLine("Pleae enter a name for the book!");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Invalid name!");
            }

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("Average: " + stats.AverageGrade);
            Console.WriteLine("Highest: " + stats.HighestGrade);
            Console.WriteLine("Lowest: " + stats.LowestGrade);
            Console.WriteLine("{0}, {1}", stats.LetterGrade, stats.Description);

        }
    }
}
