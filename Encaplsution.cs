//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DotNet1
//{
//    //programe to salary input from user using static method and static variable
//    class Employee
//    {
//        // Private field (hidden data)
//        private static  double salary;

//        // Public method to set salary
//        static void SetSalary(double sal)

//        {
//            if (sal > 0)
            
//               Employee.salary = sal;
            
//            else
            
//                Console.WriteLine("Invalid Salary");
            
//        }

//        // Public method to get salary
//        public static double GetSalary()
//        {
//            return salary;
//        }




//        static void Main()
//        {
//            // Employee emp = new Employee();
//            Console.Write("Enter Salary: ");
//            int sal = Convert.ToInt32(Console.ReadLine());
//            Employee.SetSalary(sal);

//            Console.WriteLine("Salary: " + Employee.GetSalary());
//            Console.ReadLine();
//        }

//    }

//    //////Program  using get set property to set and get salary value
//    class Employee
//    {
//        private double salary;

//        public double Salary
//        {
//            get { return salary; }
//            set
//            {
//                if (value > 0)
//                    salary = value;
//                else
//                    Console.WriteLine("Invalid Salary");
//            }
//        }
//    }

//    class XYZ
//    {
        
//    }



//}
