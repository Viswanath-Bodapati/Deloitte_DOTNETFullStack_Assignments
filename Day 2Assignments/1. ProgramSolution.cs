using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee job: ");
            string job = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            int salary = int.Parse(Console.ReadLine());

            Console.WriteLine("----Employee DETAILS----");
            Console.WriteLine("Employee ID : " + id);
            Console.WriteLine("Employee Name : " + name);
            Console.WriteLine("Employee Job : " + job);
            Console.WriteLine("Employee Salary: " + salary);

            Console.ReadLine();
        }
    }
}
