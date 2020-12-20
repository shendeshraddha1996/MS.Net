using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            demo1.classA a1 = new demo1.classA();
            // Console.WriteLine("Hello World");
            // a.display();
            // Console.ReadLine();
            a.fun1();
          a1 .display();
           int x= a1.add(1, 2, 3,4);
            int x1 = a1.add(1, 2, 3);
            int x2 = a1.add(1, 2);
      
            Console.WriteLine(x);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            Console.ReadLine();
        }
    }

    public class ClassA
    {   
        public void display()
        {
            Console.WriteLine("Hello World");
        }
       public void fun1()
        {
            int i = 2;
         int t = i * i*i;
            Console.WriteLine(t);
        }
    }

}

namespace demo1
{
    class classA
    {
       public void display()
        {
            Console.WriteLine("Namespace of demo1");
        }

        public int add(int a,int b,int c,int d)
        {
            //a = 1;b = 1;c = 1;d = 1;
            return a + b + c + d;
        }
        public int add(int a, int b, int c)
        {
            //a = 1;b = 1;c = 1;d = 1;
            return a + b + c ;
        }
        public int add(int a, int b)
        {
            //a = 1;b = 1;c = 1;d = 1;
            return a + b ;
        }
    }
}


