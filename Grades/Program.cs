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
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            book.NameChanged += (OnNameChanged);
            book.NameChanged += (OnNameChanged);
            book.NameChanged += (OnNameChanged2);
            book.Name = "allen's book";
            WriteNames(book.Name);
                        
            Console.WriteLine("Average: " + stats.AverageGrade);
            Console.WriteLine("Highest: " + stats.HighestGrade);
            Console.WriteLine("Lowest: " + stats.LowestGrade);

        }

        private static void OnNameChanged2(string oldValue, string newValue)
        {
            Console.WriteLine("*****");
        }

        private static void OnNameChanged(string oldValue, string newValue)
        {
            Console.WriteLine("Name changed from {0} to {1}", oldValue, newValue);
        }

        private static void WriteBytes(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteByteArray(bytes);
        }

        private static void WriteBytes(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteByteArray(bytes);
        }

        private static void WriteByteArray(byte[] bytes)
        {
            foreach (byte b in bytes)
            {
                Console.Write("0x{0:X} ", b);
            }
            Console.WriteLine();
        }

        private static void WriteNames(params string [] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
