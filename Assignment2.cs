using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT2
{
    class assignment2
    {
        static void Main(string[] args)
        {
            Employee e;
            e = new Manager("shraddha",10,20000,"senior");
           // e = new CEO("shraddha", 0, 20000);
            Console.WriteLine(e.EmpNo);
            e.CalcNetSalary();
            Console.WriteLine("================");
            CEO c = new CEO("shende",29,89000);
            c.display();
            Console.ReadLine( );
        }
    }

    public interface IDbFunctions
    {
        void display();
    }
    abstract class Employee
    {
       public string name;               //-> no blanks
       public int empNo;
       public short deptNo;
       public static int count;
      protected decimal basic;
       public abstract decimal Basic
        {
            set;get;
        } 
       public string Name
        {
            set
            {
                if (value != null)
                   name= value;
                else
                    Console.WriteLine("invalid");
            }
            get
            {
                return name;
            }
        }
       public int EmpNo
        {
            get { return empNo; }
            private set { empNo = value; }
        }
       public short DeptNo
        {
            get
            {
                return deptNo;
            }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("invalid");
            }

        }

        public Employee(string name = null, short deptNo = 0, decimal basic = 0)
        {
            Console.WriteLine("Employee class Constructor");
            count++;
            this.name = name;
            this.deptNo = deptNo;
            this.basic = basic;
            EmpNo = count;
        }
       

        public abstract decimal CalcNetSalary();
    }

    class Manager : Employee,IDbFunctions
    {
        public string designation;
        public string Designation
        {
            set
            {
                if (value != null)
                    designation = value;
                else
                    Console.WriteLine("invalid");
            }
            get
            {
                return designation;
            }
        }

       
        public Manager(string name, short deptNo, decimal basic,string designation):base(name,deptNo,basic)
        {
            this.designation = designation;
        }

        public override decimal Basic { get; set ; }


        public override decimal CalcNetSalary()
        {
            decimal netsalary=(20)*basic;
            Console.WriteLine(netsalary);
            return netsalary;
        }

        public void display()
        {
            Console.WriteLine(Basic+" "+designation);
        }
    }

    class GeneralManager : Manager
    {
        public string perks;
        public GeneralManager(string name, short deptNo, decimal basic, string designation,string perks):base(name, deptNo, basic, designation)
        {
            this.perks = perks;
        }
        public override decimal CalcNetSalary()
        {
            decimal netsalary = (30) * basic;
            return netsalary;
        }
    }

    class CEO : Employee,IDbFunctions
    {
       
        public CEO(string name, short deptNo, decimal basic) :base(name,deptNo,basic)
        {

        }

        public override decimal Basic { get { return basic; } set { value = basic; } }
        public sealed override decimal CalcNetSalary()
        {
            decimal netsalary = 40 * basic;
            Console.WriteLine(netsalary);
            return netsalary;
        }

        public void display()
        {
            Console.WriteLine(Basic+" "+name);
        }
    }
}
