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

            if (answer == "YES")
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

                dGrade1 = Convert.ToInt32(grade1);
                dGrade2 = Convert.ToInt32(grade2);
                dGrade3 = Convert.ToInt32(grade3);
                dGrade4 = Convert.ToInt32(grade4);

                avg = (dGrade1 + dGrade2 + dGrade3 + dGrade4) / 4;

                if (avg >= 90 && avg <= 100)
                {
                    Console.WriteLine("Your avg is a " + avg);
                    Console.WriteLine("You earned an: A");
                }
                else if (avg >= 80 && avg <=89)
                {
                    Console.WriteLine("Your avg is a" + avg);
                    Console.WriteLine("You earned a: B");
                }
                else if (avg >= 70 && avg <= 79)
                {
                    Console.WriteLine("Your avg is a" + avg);
                    Console.WriteLine("You earned a: C");
                }
                else if (avg >= 60 && avg <= 69)
                {
                    Console.WriteLine("Your avg is a " + avg);
                    Console.WriteLine("You earned a: D");
                }
                else if (avg <= 59)
                {
                    Console.WriteLine("Your avg is a" + avg);
                    Console.WriteLine("You earned a: F");
                }

                Console.Write("Would you like to run the program again? (YES or NO)");
                answer = Console.ReadLine();

            } // if end
        } // main end
    }// class end
} // namespace end
