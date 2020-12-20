using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Q1
{
    class Program
    {
        static void Main1(string[] args)
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

namespace Assignment3Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int batch,students;
            Console.WriteLine("Enter Number of batches");
            batch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("==================");
            int[][] arr = new int[batch][];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the number of students for batch {0}",i+1);
                students= Convert.ToInt32(Console.ReadLine());
                int[] marks = new int[students];  
               
                for(int j = 0; j <students; j++)
                {
                    Console.WriteLine("Enter the marks of  for Student {0}", j + 1);
                    marks[j]= Convert.ToInt32(Console.ReadLine());
                }
                arr[i] = marks;
                Console.WriteLine("==================");
            }
          //  Console.WriteLine("==================");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Marks of student of batch {0} : ", i);
                Console.WriteLine();
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("Marks of Student {0} = {1}",j+1, arr[i][j]);
                  
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

   
}

namespace Assignment3Q3
{
    class Program
    {
        static void Main3(string[] args)
        {
            Student[] s = new Student[3];
            for(int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Enter the Details of Student {0} ;-", i+1);
                s[i] = new Student();
                s[i].getdata();
            }

            Console.WriteLine("==================");
            //show student data
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Details of Student {0} ",i+1);
                Console.WriteLine(" Name= {0}",s[i].name);
                Console.WriteLine("Roll NO= {0}",s[i].rollNo);
                Console.WriteLine("Marks= {0}", s[i].marks);
                Console.WriteLine("-------------------------");
            }

            Console.ReadLine();
        }
    }
    public struct Student
    {
        public string name;
        public  int rollNo;
        public  decimal marks;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                    name = value;
                else
                    Console.WriteLine("Invalid");
            }
        }
        public int RollNo
        {
            get
            {
                return rollNo;
            }
            set
            {
                if (value >0)
                    rollNo = value;
                else
                    Console.WriteLine("Invalid");
            }
        }
        public Student(string name, int rollNo, decimal marks)
        {
            this.name = name;
            this.marks = marks;
            this.rollNo = rollNo;
            this.Name = name;

        }
        public void getdata()
        {
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the marks");
            marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the roll no");
            rollNo = Convert.ToInt32(Console.ReadLine());
        }

    }

}
