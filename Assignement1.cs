Skip to content
Search or jump to…

Pull requests
Issues
Marketplace
Explore
 
@shendeshraddha1996 
Learn Git and GitHub without any code!
Using the Hello World guide, you’ll start a branch, write comments, and open a pull request.


shendeshraddha1996
/
MS.Net
1
00
Code
Issues
Pull requests
Actions
Projects
Wiki
Security
Insights
Settings
MS.Net/Program.cs /
@shendeshraddha1996
shendeshraddha1996 Add files via upload
Latest commit 4660c0d 8 minutes ago
 History
 1 contributor
87 lines (82 sloc)  2.06 KB
  
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
            Console.WriteLine(Employee.count);
            Console.WriteLine("name= "+o1.name+"  EmpNO= "+o1.EmpNo); 
           Console.WriteLine("Name =" + o2.name + " empNo= " + o2.EmpNo);
            Console.WriteLine("Name =" + o3.name + " empNo= " + o3.EmpNo);
            Console.WriteLine("Name =" + o4.name + " empNo= " + o4.EmpNo);
            Console.ReadLine();
        }
    }

    class Employee
    {
        public string name;
        public static int count;
        public int EmpNo;
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
            count++;
            this.name = name;
            this.basic = basic;
            this.deptNo = deptNo;
            EmpNo=count;
        }  
        public  decimal GetNetSalary()
        {
            decimal netSalary;
            netSalary = basic + (1/5) * basic;
            return netSalary;
        }
    }
}
© 2020 GitHub, Inc.
Terms
Privacy
Security
Status
Help
Contact GitHub
Pricing
API
Training
Blog
About
