using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            classA.i = 1234;
            classA.display();
            Console.WriteLine(classA.i);
            Console.ReadLine();
        }
    }
    class classA
    {
       static classA(){
           
            Console.WriteLine(" static contructoe");
        }

        static public int i;//single copy entire program
        public static void display()
        {
            Console.WriteLine("static method called");
        }
    }

    public static class classB
    {


    }
}
