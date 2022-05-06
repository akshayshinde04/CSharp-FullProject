using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            
            Console.WriteLine("Enter your number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            
            if (num1 == num2)
            {
                Console.WriteLine("Number 1 and  Number 2 are equal");
            }
            else
            {
                Console.WriteLine("Number 1 and  Number 2 are notequal ");
            }

            Console.ReadLine();
        }
    }
}

