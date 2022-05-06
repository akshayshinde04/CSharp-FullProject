using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeProject5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter your number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            if (num1 > 0)
            {
                Console.WriteLine("Number is Positive");
            }
            else if (num1 < 0 )
            {
                Console.WriteLine("Number is negative ");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }
            Console.ReadLine();
        }
    }
}

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, Result; char operations;
            Console.WriteLine("Enter number1: "); number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2: "); number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("choose operation ");
            Console.WriteLine("1 Addition"); Console.WriteLine("2 substraction");
            Console.WriteLine("3 Multiplication"); Console.WriteLine("4 Division");
            operations = char.Parse(Console.ReadLine());
            switch (operations)
            {
                case '1':
                    Result = number1 + number2; Console.WriteLine("Addition of two number is ={0}", Result);
                    break;
                case '2':
                    Result = number1 - number2; Console.WriteLine("Substraction of two number is ={0}", Result);
                    break;
                case '3':
                    Result = number1 * number2; Console.WriteLine("Multiplication of two number is ={0}", Result);
                    break;
                case '4':
                    Result = number1 / number2; Console.WriteLine("Division of two number is ={0}", Result);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }
        }
    }
}
