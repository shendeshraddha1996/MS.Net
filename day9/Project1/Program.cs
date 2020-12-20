using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main1(string[] args)
        {
            Action o1 = display;
            o1();
            Console.WriteLine("---------------------");
            Func<int, int, int> f1 = add;
            Console.WriteLine(f1(10, 20));
            Console.WriteLine("---------------------");
            Func<int,string,int> f2 = doSomething;
            Console.WriteLine("---------------------");
            Predicate <int> p1= evenodd;
            Console.WriteLine(p1(5)); 
            Console.ReadLine();
        }
        static void display()
        {
            Console.WriteLine("Display() ");
        }
        static int add(int a,int b)
        {
            return a + b;
        }
        static int doSomething(int a,string s)
        {
            return 1;
        }
        static bool evenodd(int n)
        {
            return n % 2 == 0;
        }
    }
}

namespace AnonymousDemo
{
    class Program
    {
        static void Main2(string[] args)
        {
            Action o1 =delegate{ Console.WriteLine("Display() "); };
            o1();
            Console.WriteLine("---------------------");
            Func<int, int, int> f1 = delegate (int a, int b)
              {
                  return a + b;
              };
            Console.WriteLine(f1(10,20));
            Console.WriteLine("---------------------");
            Predicate<int> p1 = delegate (int n)
               {
                   return n % 2 == 0;
               };
            Console.WriteLine(p1(4));
            Console.ReadLine();
        }
       
    }
}

namespace LamdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("---------------------");
            Func<int, int, int> f1 = (a,b) => a + b; ;
            Console.WriteLine(f1(10, 20));
            Console.WriteLine("---------------------");
            Func<int, int, int> f2 = (a, b) =>
            {
                int c;
                c = a;
                a = b;
                b = c;
                return a; 
               
            };
            Console.WriteLine(f2(10, 20)); 
           // Func<int, string, int> f2 = doSomething;
            
            Console.ReadLine();
        }
       
    }
}
