// Brandon Trumpold
// 7/18/2018
// Student grade averages calculator



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            String fName, answer, grade1, grade2, grade3, grade4;
            Double dGrade1, dGrade2, dGrade3, dGrade4, avg;

            Console.WriteLine("Weclcome to the Grade Average Calculator");

            Console.Write("Would you like to run the program? (YES or NO)");
            answer = Console.ReadLine();

            while (answer == "YES")
            {
                Console.Write("Please enter your first name:");
                fName = Console.ReadLine();

                Console.Write("Enter your first grade:");
                grade1 = Console.ReadLine();

                Console.Write("Enter your second grade:");
                grade2 = Console.ReadLine();

                Console.Write("Enter your third grade:");
                grade3 = Console.ReadLine();

                Console.Write("Enter your fourth grade:");
                grade4 = Console.ReadLine();

                dGrade1 = Convert.ToInt32(grade1);  //  |   Converts string to double   |
                dGrade2 = Convert.ToInt32(grade2);  //  |   Converts string to double   |
                dGrade3 = Convert.ToInt32(grade3);  //  |   Converts string to double   |
                dGrade4 = Convert.ToInt32(grade4);  //  |   Converts string to double   |

                avg = (dGrade1 + dGrade2 + dGrade3 + dGrade4) / 4;

                Console.Clear();

                if (avg >= 90 && avg <= 100)    // | Output if grade = A |
                {
                    Console.WriteLine("Your avg is a " + avg);
                    Console.WriteLine("You earned an: A");
                }
                else if (avg >= 80 && avg <= 89)    // | Output if grade = B |
                {
                    Console.WriteLine("Your avg is a " + avg);
                    Console.WriteLine("You earned a: B");
                }
                else if (avg >= 70 && avg <= 79)    // | Output if grade = C |
                {
                    Console.WriteLine("Your avg is a " + avg);
                    Console.WriteLine("You earned a: C");
                }
                else if (avg >= 60 && avg <= 69)    // | Output if grade = D |
                {
                    Console.WriteLine("Your avg is a " + avg);
                    Console.WriteLine("You earned a: D");
                }
                else if (avg <= 59)     // | Output if grade = F |
                {
                    Console.WriteLine("Your avg is a " + avg);
                    Console.WriteLine("You earned a: F");
                }

                Console.Write("Would you like to run the program again? (YES or NO)");
                answer = Console.ReadLine();

                Console.Clear();

            } // if end
        } // main end
    }// class end
} // namespace end