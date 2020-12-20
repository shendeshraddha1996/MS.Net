using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //classA a = new classA();
            //a.i = 120;
            // a.setInt(190);
            // Console.WriteLine(a.getInt());
            classB b = new classB();
            // b.P1 = 1120;
            // Console.WriteLine(b.P1);
            // Console.WriteLine(b.S1);
            Console.WriteLine(b.P1);
            classB b1 = new classB(123);
            Console.WriteLine(b1.P1);
            Console.WriteLine("====================");
            classC c = new classC();
            Console.WriteLine(c.T1);
            classC c1 = new classC(123);
            Console.WriteLine(c1.T1);
            Console.ReadLine();
        }
    }
   class classA
    {
       private int i;
        public void setInt(int x)
        {
            if(x<100)
               i=x;
            else
                Console.WriteLine("not valid");
        }
        public int getInt()
        {
            return i;
        }
    }
    class classB
    {
        public classB(){
            Console.WriteLine(" no para constrctor called");
            P1 = 5;

        }
        public classB(int P1)
        {
            Console.WriteLine("int para constrctor called");
            this.P1 = P1;

        }

        private int p1;
        public int P1  //property
        {
            set
            {
                if (value < 100)
                    p1 = value;
                else
                    Console.WriteLine("invalid");
            }
            get
            {
                return p1;
            }
        }

        private string s1="hello";
        public string S1
        {
            get
            {
               return  s1;
            }
        }
    }

    class classC
    {
        private int t1;
        public int T1
        {
            set
            {
                value = t1;
            }
            get
            {
                return t1;
            }
            
        }
        public classC()
        {
            Console.WriteLine(" no para constrctor called");
            t1 = 5;
        }
        public classC(int a)
        {
            Console.WriteLine("para constrctor called");
            t1 = a;
        }
    }
}
