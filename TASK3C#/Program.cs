using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Guessing Game
            Random random = new Random();

            int number = random.Next(50, 76);

            int attempts = 1;

            Console.WriteLine("===== Guessing Game =====");

            Console.Write("Guess a number between 50 and 75: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            while (guess != number)
            {
                if (guess < number)
                {
                    Console.WriteLine("Try a higher number.");
                }
                else
                {
                    Console.WriteLine("Try a lower number.");
                }

                Console.Write("Guess again: ");
                guess = Convert.ToInt32(Console.ReadLine());

                attempts++;
            }

            Console.WriteLine("Congratulations!");

            int points = 0;

            if (attempts == 1)
            {
                points = 10;
            }
            else if (attempts == 2)
            {
                points = 7;
            }
            else if (attempts == 3)
            {
                points = 5;
            }
            else
            {
                points = 0;
            }

            Console.WriteLine("Attempts: " + attempts);
            Console.WriteLine("Points: " + points);



            //part 2
            string[] students = { "Ahmad", "Sara", "Omar", "Lina", "Yazan" };

            int[] grades = { 85, 92, 68, 75, 90 };

            Console.WriteLine("Students:");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            Console.WriteLine("Grades:");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

        }
    }
}
