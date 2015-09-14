using System;
using System.Collections.Generic;
using System.Speech.Synthesis;


namespace Grades
{
    class Program
    {
        static void GiveBookAName(ref GradeBook book)
        {
            book.Name = "The Gradebook";
        }

        static void IncrementNumber(ref int number)
        {
            number += 1;
        }

        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("My name is butt!");

            Arrays();

            //Immutable();
            //PassByValueAndRef();


            //GradeBook book = new GradeBook();
            //book.AddGrade(91);
            //book.AddGrade(89.1f);
            //book.AddGrade(75);

            //GradeStatistics stats = book.ComputeStatistics();

            //Console.WriteLine("Average: " + stats.AverageGrade);
            //Console.WriteLine("Highest: " + stats.HighestGrade);
            //Console.WriteLine("Lowest: " + stats.LowestGrade);

        }

        private static void Arrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            foreach (float grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        private static void AddGrades(float[] grades)
        {
            if (grades.Length >= 3)
            {
                grades[0] = 91f;
                grades[1] = 89.1f;
                grades[2] = 75f;
            }
        }

        private static void Immutable()
        {
            string name = " Scott ";
            name = name.Trim();

            DateTime date = new DateTime(2014, 1, 1);
            date = date.AddHours(25);

            Console.WriteLine(date);
            Console.WriteLine(name);
        }

        private static void PassByValueAndRef()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(ref g2);
            Console.WriteLine(g2.Name);

            int x1 = 4;
            IncrementNumber(ref x1);
            Console.WriteLine(x1);
        }
    }
}
