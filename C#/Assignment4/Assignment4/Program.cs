using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        
        public abstract class Student
        {
            public String Name;
            public int StudentId;
            public abstract void BooleanIspassed(int Grade);
        }
        public class Undergraduate : Student
        {
            public override void BooleanIspassed(int Grade)
            {
                try
                {

                    Console.WriteLine("Enter the undergraduate student Grade ");
                    Grade = Convert.ToInt32(Console.ReadLine());
                    if (Grade > 70)
                    {
                        Console.WriteLine("undergraduate student passed the course ");
                    }
                    else
                    {
                        Console.WriteLine("undergraduate student failed the course ");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("input mismatch exception " + e.StackTrace);
                }
            }
        }

        class Graduate : Student
        {
            public override void BooleanIspassed(int Grade)
            {
                try
                {
                    Console.WriteLine("\n Enter the graduate student Grade");
                    Grade = Convert.ToInt32(Console.ReadLine());
                    if (Grade > 80)
                    {
                        Console.WriteLine("Graduate student passed the course ");
                    }
                    else
                    {
                        Console.WriteLine("Graduate student failed the course ");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Input missmatch exception " + e.StackTrace);
                }
            }
        }
        public class Employee
        {
            public int empId;
            public string empName;
            public float salary;

            public Employee(int empId, string empName, float salary)
            {
                this.empId = empId;
                this.empName = empName;
                this.salary = salary;
            }
            public void dispDetails()
            {
                Console.WriteLine($"\n empName {empName} with empid {empId} gets salary of {salary}");
            }
        }
        public class PartTimeemployee
        {
            public int wages = 1000;

            public void showDetails()
            {
                Console.WriteLine($"The parttime employee gets " + wages);
            }
        }
        public class Students
        {
            public int stId;
            public string stName;
            public double examFee;


            public void displayDetails()
            {
                Console.WriteLine($"\nthe student {stName} with id {stId} paid {examFee}");
            }
            public void payFee()
            {
                Console.WriteLine("\nEnter student id: ");
                stId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the student name: ");
                stName = Console.ReadLine();
                Console.WriteLine("The exam fee: is" + 1000);
                Console.WriteLine("Enter the amount to pay examfee");
                examFee = int.Parse(Console.ReadLine());
                double rem_fee = 1000 - examFee;
                if (examFee == 1000)
                {
                    Console.WriteLine("Full fees paid no dues");
                }
                else
                {
                    Console.WriteLine("The remaining fee: " + rem_fee);
                }
            }
        }
        class DayScholar
        {
            public double transportFees;

            public DayScholar(double transport_fees)
            {
                this.transportFees = transport_fees;
                double rem1Fee = 5000 - transport_fees;

                Console.WriteLine("\nthe transport fee: " + 10000 + "per year ");


                Console.WriteLine($"the dayscholar  paid {transportFees} & remaining fee is {rem1Fee}");
                Console.WriteLine();
            }

        }
        public class Hosteller
        {
            public double hostelFee;

            public Hosteller(double hostelFee)
            {

                this.hostelFee = hostelFee;

                double rem2Fee = 40000 - hostelFee;
                Console.WriteLine("the hostel  fee: " + 30000 + "per year ");

                Console.WriteLine($"the dayscholar  paid {hostelFee} & remaining fee is {rem2Fee} ");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Undergraduate ug = new Undergraduate();
            ug.BooleanIspassed(10);
            ug.Name = "Capt Jack";
            ug.StudentId = 001;
            Console.WriteLine($"name is {ug.Name} & id is {ug.StudentId}");

            Graduate g = new Graduate();
            g.Name = "Iron Man";
            g.StudentId = 002;
            g.BooleanIspassed(20);
            Console.WriteLine($"name is {g.Name} & id is {g.StudentId}");


            Employee employee = new Employee(001, "Capt Jack", 1000f);
            employee.dispDetails();
            PartTimeemployee ptemployee = new PartTimeemployee();
            ptemployee.showDetails();

            Students students = new Students();
            students.payFee();
            students.displayDetails();
            Console.WriteLine("enter the tranport fee you want to pay: ");
            DayScholar dayScholar = new DayScholar(int.Parse(Console.ReadLine()));
            Console.WriteLine("enter the hostel fee you want to pay: ");
            Hosteller hosteller = new Hosteller(int.Parse(Console.ReadLine()));




            Console.ReadLine();
        }

    }
}
