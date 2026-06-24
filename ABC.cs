using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet1
{
    class Employee
    {
        private double salary;

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
                else
                    Console.WriteLine("Invalid Salary");
            }
        }
    }

    internal class ABC
    {

        static void Main()
        {
            Employee emp = new Employee();

            emp.Salary = 50000;

            Console.WriteLine("Salary: " + emp.Salary);
        }
    }
}
