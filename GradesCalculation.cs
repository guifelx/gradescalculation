using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace StudentsGrades
{
    public class GradesCalculation
    {
        private List<string> students = new List<string>();
        private List<double> grades = new List<double>();
        private List<double> averageGrades = new List<double>();
        public void AddStudent()
        {
            Console.WriteLine("How many students would you like to register? ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < quantity; i++)
            {
                Console.Write("Enter the students name: ");
                students.Add(Console.ReadLine());
            }


        }

        public void Average()
        {
            Console.Write("Enter the number of tests: ");
            int tests = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Enter the tests scores");

            for (int i = 0; i < students.Count; i++)
            {
                double average = 0;  // Mover a declaração para dentro do loop para calcular a média para cada aluno
                for (int j = 0; j < tests; j++)
                {
                    Console.Write($"{students[i]}'s {j + 1}st test score: ");  // Corrigir o índice do teste
                    average += Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                average /= tests; // Calcular a média após a coleta de todas as notas
                averageGrades.Add(Math.Round(average, 2));
                Console.Clear();
            }
        }

        public void ExhibitGrades()
        {
            Console.WriteLine("Final grades");
            for (int i = 0; i < students.Count; i++)
            {
                string passedOrNot;

                if (averageGrades[i] > 6)
                {
                    passedOrNot = "Approved";
                }
                else if (averageGrades[i] < 6 && averageGrades[i] > 5)
                {
                    passedOrNot = "Exam";
                }
                else
                {
                    passedOrNot = "Failed";
                }
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Student: {students[i]}");
                Console.WriteLine($"Grade Average: {averageGrades[i]}");
                Console.WriteLine($"STATUS: {passedOrNot}");

            }
        }
    }
}