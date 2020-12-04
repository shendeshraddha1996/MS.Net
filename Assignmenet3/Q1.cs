using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] e = new Employee[3];
            for(int i = 0; i < e.Length; i++)
            {
                Console.WriteLine("Enter the Details of Employee {0} ;-",i);
                e[i] = new Employee();
                e[i].getdata();
            }
            Console.WriteLine("==================");
            //employee with the heighest salary
            decimal maxSalary = e[0].EmpSalary;
            string maxSalaryEmpName=null;
            for(int i = 1; i < e.Length; i++)
            {
                if (e[i].EmpSalary > maxSalary)
                {
                    maxSalary = e[i].EmpSalary;
                    maxSalaryEmpName = e[i].EmpName;
                }
                 
            }
            Console.WriteLine("EmpName= {0} , HeighestSalary= {1}", maxSalaryEmpName,maxSalary);
            Console.WriteLine("==================");
            Console.WriteLine("Enter the EmpNo");
            int eno= Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < e.Length; i++)
            {
                if (eno == e[i].EmpNo)
                {
                    Console.WriteLine("Name={0}", e[i].EmpName);
                    Console.WriteLine("Salary={0} ", e[i].EmpSalary);
                }
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int EmpNo;
        public string EmpName;
        public decimal EmpSalary;
        
        public void getdata()
        {
            Console.WriteLine("Enter the name");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter the Emp NUmber");
            EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the salary");
            EmpSalary = Convert.ToInt32(Console.ReadLine());
        }
       
    }
}
