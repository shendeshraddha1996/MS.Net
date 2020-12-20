using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

//namespace OOverloading
//{
//    class Program
//    {
//        static void Main1(string[] args)
//        {
//            classA a = new classA {i=10};
//            a = a + 15;
//            Console.WriteLine(a.i);
//            Console.WriteLine("---------------------");
//            classA a1 = new classA { i=2};
//            classA a2 = new classA { i=10};
//            a= a1 + a2;
//            Console.WriteLine(a.i);
//            Console.WriteLine("---------------------");
//            a=a++;
//            Console.WriteLine(a.i);
//            Console.WriteLine("---------------------");
//            classB b = new classB(5);
//            b[0] = 100;
//            b[1] = 1;
//            Console.WriteLine(b[0]+" "+b[1]);
//            Console.ReadLine();

//        }
//    }
//    class classA
//    {
//        public int i;
//        public static classA operator+(classA a,int i)
//        {
//            classA retval = new classA();
//            retval.i = a.i - i;
//            return retval;
//        }
//        public static classA operator +(classA a1, classA a2)
//        {
//            classA retval = new classA();
//            retval.i = a1.i+a2.i;
//            return retval;
//        }
//        public static classA operator ++(classA a)
//        {
//            classA retval = new classA();
//            retval.i = ++a.i;
//            return retval;
//        }

//    }

//    class classB
//    {
//        int[] arr;
//        public classB(int size)
//        {
//            arr = new int[size];
//        }
//        public int this[int index]
//        {
//            set
//            {
//                arr[index] = value;
//            }
//            get
//            {
//                return arr[index];
//            }
//        }
//    }
//}

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:\Users\shradhha shende\source\repos\Day1\BasicClassConcepts\bin\Debug
            Assembly asm = Assembly.LoadFrom(@"D:\DOTNET\practice\practice\bin\Debug\practice.exe");
            Console.WriteLine(asm.FullName);
            Type[] arrTypes = asm.GetTypes();
            foreach (Type t in arrTypes)
            {
                Console.WriteLine(t.Name);
              
                MethodInfo[] mf=t.GetMethods();
                foreach (MethodInfo m in mf)
                {
                    Console.WriteLine(m.Name);
                    ParameterInfo[] pm =m.GetParameters();
                    foreach (ParameterInfo p in pm)
                    {
                        Console.WriteLine(p.Name);
                        Console.WriteLine("--------------");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}