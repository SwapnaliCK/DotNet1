using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet1
{

    class Employee
    {
        // Private field (hidden data)
        private double salary;

        // Public method to set salary
        public void SetSalary(double sal)
        {
            if (sal > 0)    
            {
                salary = sal;
            }
            else
            {
                Console.WriteLine("Invalid Salary");
            }
        }

        // Public method to get salary
        //
        public double GetSalary()
         
        {
            return salary;
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp = new Employee();

            emp.SetSalary(50000);

            Console.WriteLine("Salary: " + emp.GetSalary());
        }
    }
}
