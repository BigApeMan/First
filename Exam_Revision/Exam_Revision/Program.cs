using System;

namespace Exam_Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            string temp;
            char again = '\0';
            int total = 1;
            do
            {

                Console.WriteLine("please input your first number: ");
                temp = Console.ReadLine();
                number1 = Convert.ToInt32(temp);
                Console.WriteLine("Please enter your second number: ");
                temp = Console.ReadLine();
                number2 = Convert.ToInt32(temp);

                if (number1 == number2)
                {
                    Console.WriteLine("The following is a true statement");
                    Console.WriteLine(number1 == number2);
                    Console.ReadLine();
                }
                else
                {

                    if (number1 < number2)
                    {
                        Console.WriteLine("the following statement is true");
                        Console.WriteLine(number1 < number2);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("the following statement is true");
                        Console.WriteLine(number1 > number2);
                        Console.ReadLine();
                    }
                }


                Console.WriteLine("Do you want to play again? Y N: ");
                temp = Console.ReadLine();
                again = Convert.ToChar(temp);

                if ((again == 'Y') || (again == 'y'))
                {
                    total = total + 1;
                }

            } while ((again != 'N') || (again != 'n'));

            Console.WriteLine("The total amount of times you played this games is: " + total);
        }
    }
}


