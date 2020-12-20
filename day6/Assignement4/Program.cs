using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement4_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,Employee> listOfEmployee = new SortedList<int,Employee>();
            Employee emp = new Employee();
            //listOfEmployee.Add(new Employee { EmpNo=1, EmpName ="shraddha", EmpSalary =8000});
            //listOfEmployee.Add( new Employee { EmpNo = 2, EmpName = "shankar", EmpSalary = 10000 });
            //listOfEmployee.Add( new Employee { EmpNo = 3, EmpName = "pravin", EmpSalary = 12000 });
            string s=null;
            int i = 1;
            while (true)
            {
                Console.WriteLine("Do you want to enter the employee details");
                s = Console.ReadLine();
                if (s == "yes" || s == "y")
                {   
                    
                    Console.WriteLine("Enter employee number");
                    emp.EmpNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter employee name");
                    emp.EmpName = Console.ReadLine();
                    Console.WriteLine("Enter employee salary");
                    emp.EmpSalary = Convert.ToInt32(Console.ReadLine());
                    listOfEmployee.Add(i,emp);
                    i++;
                }
                //else
                //{
                //    break;
                //}
            }
            
            
            Console.WriteLine("========================");
            //display details
            foreach (KeyValuePair<int, Employee> obj in listOfEmployee)
            {
                Console.WriteLine(obj.Value.EmpNo+" "+obj.Value.EmpName+" "+obj.Value.EmpSalary);
                Console.WriteLine("----------------------");
            }
            Console.WriteLine("========================");
            //highest salary employee
           // Console.WriteLine(listOfEmployee.Max<Employee>().EmpSalary); 
            Console.ReadLine();
        }
    }
    public class Employee
    {
        public int empNo;
        string empName;
        int empSalary;
        public int EmpNo
        {
            get
            {
                return empNo;
            }
            set
            {
                if (value > 0)
                    empNo = value;
                else
                    Console.WriteLine("Invalid");
            }
        }

        public string EmpName
        {
            get
            {
                return empName;
            }
            set
            {
                if (value != null)
                    empName  = value;
                else
                    Console.WriteLine("Invalid");
            }
        }

        public int EmpSalary
        {
            get
            {
                return empSalary;
            }
            set
            {
                if (value > 0)
                    empSalary = value;
                else
                    Console.WriteLine("Invalid");
            }
        }


    }
}
