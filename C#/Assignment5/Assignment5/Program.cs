using System;

namespace Assignment5
{
    public class WithdrawnException : ApplicationException
    {
        public WithdrawnException(string msg) : base(msg)
        {

        }
    }
    public class Bank
    {
        float Amount = 10000.00f;
        float Balance;
        string AccName;
        string AccNumber;

        public Bank()
        {
            Console.WriteLine("Enter the Account Number : ");
            AccNumber = Console.ReadLine();
            Console.WriteLine("Enter the Account holder Name :");
            AccName = Console.ReadLine();

            Console.WriteLine($"The Account details is : AccountNum {AccNumber}, Acount Namer {AccName}, Amount is {Amount}");

        }


        public void DepositeAmount()
        {
            Console.WriteLine("Enter the Deposited Amount : ");
            float DepositeAmount = Convert.ToSingle(Console.ReadLine());

            if (DepositeAmount == 0)
            {
                Console.WriteLine("Deposite the minimum amount above 1000.00 ");

            }
            else
            {
                Balance = Amount + DepositeAmount;
                Console.WriteLine("Your Account Balance is After amount deposite : " + Balance);
            }
        }

        public void AmountWithdrawn()
        {

            Console.WriteLine("Enter the WithDrawn Amount : ");
            float WithdrawnAmount = Convert.ToSingle(Console.ReadLine());


            if (WithdrawnAmount > Balance)
            {
                throw (new WithdrawnException("Insufficent balance"));
            }
            else
            {
                Balance = Balance - WithdrawnAmount;
                Console.WriteLine("Your Account Balance is After With Draw the amount :" + Balance);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            try
            {
                bank.DepositeAmount();
                bank.AmountWithdrawn();

            }
            catch (WithdrawnException we)
            {
                Console.WriteLine(we.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"Enter only numbers ", fe);
            }
            Console.Read();
        }
    }
}

       

