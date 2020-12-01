using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();
            Console.WriteLine(Employee.EmpNo);
            Console.ReadLine();
        }
    }

    class Employee
    {
        public string name;
        public static int EmpNo;
        public decimal basic;
        public short deptNo;
        public string Name
        {
            set
            {
                if (value != null)
                    value = name;
                else
                    Console.WriteLine("should not be null");
            }
            get
            {
                return name;
            }
        }

        public decimal Basic
        {
            set
            {
                if (value > 100)
                    value = basic;
                else
                    Console.WriteLine("should be greater than 100");
            }
            get
            {
                return basic;
            }
        }

        public short DeptNo
        {
            set
            {
                if (value > 0)
                    value = deptNo;
                else
                    Console.WriteLine("should be greater than 0");
            }
            get
            {
                return deptNo;
            }
        }

        public Employee(string name=null, decimal basic=0, short deptNo=0)
        {
            EmpNo++;
            this.name = name;
            this.basic = basic;
            this.deptNo = deptNo;
        }  
        public  decimal GetNetSalary()
        {
            decimal netSalary;
            netSalary = basic + (1/5) * basic;
            return netSalary;
        }
    }
}
