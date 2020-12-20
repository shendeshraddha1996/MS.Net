using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("enter a number");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(i+10);
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(i+50);
            Console.ReadLine();
        }
    }
}

namespace Inheritance
{
    class Program
    {
        static void Main2(string[] args)
        {
            //Baseclass b;
            //  b = new Baseclass();
            DerivedClass d;
            d = new DerivedClass();
            Console.WriteLine("===============");
            d = new DerivedClass(10,20);
            Console.WriteLine("===============");
            Baseclass b = new DerivedClass();
            Console.ReadLine();
        }
    }

    class Baseclass
    {
        public int a;
        public Baseclass()
        {
            Console.WriteLine("Base Class no para Constructor");
        }
        public Baseclass(int a)
        {
            Console.WriteLine("Base Class int para Constructor");
            this.a = a;
        }
    }

    class DerivedClass : Baseclass
    {
        public int b;
        public DerivedClass()
        {
            Console.WriteLine("derived Class no para Constructor");
        }

        public DerivedClass(int a,int b):base(a)
        {
            Console.WriteLine("derived Class two para Constructor   "+a);
            this.b = b;
        }
    }
}


//overriding hiding overloading
namespace Inheritance2
{
    class Program
    {
        static void Main3(string[] args)
        {
             Baseclass b;
             b = new DerivedClass();
             DerivedClass d = new DerivedClass();
             d.display("Hello");
             b.display();
             Console.WriteLine("=======================");
             b.display1();
             d.display1();
             Console.WriteLine("=======================");
            // b = new Baseclass();
            // b.display1();
            Console.WriteLine("=======================");
            b.display2();
            d.display2();
            Console.WriteLine("=======================");
            b.display3();
            d.display3(); 
            Console.WriteLine("=======================");
            b.display3();
            Console.ReadLine();
        }
    }
    class Baseclass
    {
        public int a;
        public Baseclass()
        {
            Console.WriteLine("Base Class no para Constructor");
        }
        public Baseclass(int a)
        {
            Console.WriteLine("Base Class int para Constructor");
            this.a = a;
        }
        public void display()
        {
            Console.WriteLine("Base Class display()");
        }
        public virtual void display1()
        {
            Console.WriteLine("Base Class display1()");
        }
        public  void display2()
        {
            Console.WriteLine("Base Class display2()");
        }
        public void display3()
        {
            Console.WriteLine("Base Class display3()");
        }
    }

    class DerivedClass : Baseclass
    {
        public int b;
        public DerivedClass()
        {
            Console.WriteLine("derived Class no para Constructor");
        }

        public DerivedClass(int a, int b) : base(a)
        {
            Console.WriteLine("derived Class two para Constructor   " + a);
            this.b = b;
        }
        public void display(string s)
        {
            Console.WriteLine("Derived Class display()");
        }
        public override void display1()
        {
            Console.WriteLine("Derived Class display1()");
        }
        public new void display2()
        {
            Console.WriteLine("Derive Class display2()");
        }
        public void display3()
        {
            Console.WriteLine("Derived Class display3()");
        }
    }

}

namespace Inheritance3
{
    class Program
    {
        static void Main3(string[] args)
        {
            Baseclass b;
            b = new DerivedClass();
            b.display();
            Console.WriteLine("=================");
            DerivedClass1 dc = new DerivedClass1();
            dc.show();
            dc.show1();
            Console.ReadLine();
        }
    }

    public abstract class Baseclass
    {
        public void display()
        {
            Console.WriteLine("abstract class-display method");
        }
       
    }

    class DerivedClass : Baseclass
    {
        
    }

    public abstract class AbstractClass
    {
        public abstract void show();
        public abstract void show1();
    }
    public class DerivedClass1 : AbstractClass
    {
        public override void show()
        {
            Console.WriteLine("derive class show method");
        }

        public override void show1()
        {
            Console.WriteLine("derive class show1 method");
        }
    }
}

namespace Inheritance4
{
    class Program
    {
        static void Main(string[] args)
        {
            /// DerivedClass b;
            // b = new DerivedClass();
            // b.display();
            DerivedClass sb = new SubDerivedClass();
            sb.display();
            
            Console.ReadLine();
        }
    }

    class Baseclass
    {
        public virtual void display()
        {
            Console.WriteLine( "base display");
        }
       
    }

    class DerivedClass : Baseclass
    {

        public sealed override void display()
        {
            Console.WriteLine("derive display");
        }

    }

    class SubDerivedClass : DerivedClass
    {
        public new void display()
        {
            Console.WriteLine("subderive display");
        }
    }
}
