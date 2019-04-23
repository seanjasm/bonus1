using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeRange gradeRange = new GradeRange();  

         Console.Write("");
            do
            {
                double grade = 0.0;

                Console.Clear();

                Console.WriteLine("\t\tWelcome to the Letter Grade Converter!\n\n");

                //User input grade
                Console.Write("\n\n\nEnter grade:  ");

                while (!double.TryParse(Console.ReadLine(), out grade))
                {
                    Console.Write("\n\aInput is not understood.\n\nEnter a valid decimal for the grade:  ");
                }
                Console.Write("Letter grade: {0}", gradeRange.GetLetterGrade(grade));

                Console.Write("\n\n\nPress [N] to quit: ");

            } while (Console.ReadLine().ToLower() != "n");

        }
    }
}
