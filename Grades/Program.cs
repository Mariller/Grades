using System;
using System.Collections.Generic;
using System.IO;
using System.Speech.Synthesis;


namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradeBook();

            try
            {
                using (FileStream stream = File.Open("grades.txt", FileMode.Open))
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        float grade = float.Parse(line);
                        book.AddGrade(grade);
                        line = reader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Could not locate the file grades.txt");
                return;
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("No access");
                return;
            }


            foreach (float grade in book)
            {
                Console.WriteLine(grade);
            }

            try
            {

                Console.WriteLine("Pleae enter a name for the book!");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid name!");
            }

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("Average: " + stats.AverageGrade);
            Console.WriteLine("Highest: " + stats.HighestGrade);
            Console.WriteLine("Lowest: " + stats.LowestGrade);
            Console.WriteLine("{0}, {1}", stats.LetterGrade, stats.Description);

        }

        private static IGradeTracker CreateGradeBook()
        {
            IGradeTracker book = new ThrowAwayGradeBook("Delan's Book");
            return new ThrowAwayGradeBook("Delan's Book");
        }
    }
}
