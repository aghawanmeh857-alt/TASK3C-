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


            Console.WriteLine("//////////////////////////////////part2");

            // Part 2: School System

            string[] students = { "Ahmad", "Sara", "Omar", "Lina", "Yazan" };

            int[] grades = { 85, 92, 68, 75, 90 };

            int choice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("===== School System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Students:");

                        for (int j = 0; j < students.Length; j++)
                        {
                            Console.WriteLine(students[j]);
                        }

                        Console.WriteLine("Grades:");

                        foreach (int g in grades)
                        {
                            Console.WriteLine(g);
                        }

                        break;


                    case 2:

                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();

                        int i = 0;
                        bool found = false;

                        while (i < students.Length)
                        {
                            if (students[i] == name)
                            {
                                Console.WriteLine("Student Found!");
                                found = true;
                                break;
                            }

                            i++;
                        }

                        if (found == false)
                        {
                            Console.WriteLine("Student Not Found.");
                        }

                        break;


                    case 3:

                        Console.Write("Enter student grade: ");
                        int grade = Convert.ToInt32(Console.ReadLine());

                        if (grade < 0 || grade > 100)
                        {
                            Console.WriteLine("Invalid Grade");
                        }
                        else if (grade >= 90)
                        {
                            Console.WriteLine("Excellent");
                        }
                        else if (grade >= 80)
                        {
                            Console.WriteLine("Very Good");
                        }
                        else if (grade >= 70)
                        {
                            Console.WriteLine("Good");
                        }
                        else if (grade >= 60)
                        {
                            Console.WriteLine("Pass");
                        }
                        else
                        {
                            Console.WriteLine("Fail");
                        }

                        break;


                    case 4:

                        Console.WriteLine("Goodbye!");
                        break;


                    default:

                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 4);

        }
    }
}