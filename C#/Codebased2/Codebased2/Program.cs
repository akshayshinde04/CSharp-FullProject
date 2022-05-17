using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace codebase2
{ 
public delegate void calculator(int a, int b);



class Program
{
    public static void add(int a, int b)
    {
        int res = a + b;
        Console.WriteLine("Addition result is {res}");
    }
    public static void sub(int a, int b)
    {
        int res = a - b;
        Console.WriteLine("Substraction result is {res}");
    }
    public static void multi(int a, int b)
    {
        int res = a * b;
        Console.WriteLine("Multiplication result is {res}");
    }
    public static void divi(int a, int b)
    {
        int res = a / b;
        Console.WriteLine("Division result is {res}");
    }
    static void Main(string[] args)
    {
        calculator obj = new calculator(Program.add);
        obj.Invoke(10, 20);
        obj = sub;
        obj(20, 10);
        obj = multi;
        obj(30, 40);
        obj = divi;
        obj(50, 10);
        Console.ReadLine();
    }
    }
}


