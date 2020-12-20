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
            Struct1 s = new Struct1();
            s.Mypoint(20,30);
            Console.WriteLine("===============");
            Display(TimeOfDay.Afternoon);
            Display(TimeOfDay.Morning);
            Console.ReadLine();
        }
        static void Display(TimeOfDay t)
        {
            if (t == TimeOfDay.Morning)
                Console.WriteLine("Good Morning");
            else if (t == TimeOfDay.Afternoon)
                Console.WriteLine("Good Afternoon");
            else if (t == TimeOfDay.Evening)
                Console.WriteLine("Good Evening");
            else if (t == TimeOfDay.Night)
                Console.WriteLine("Good Night");
        }
    }


    public enum TimeOfDay
    {
        Morning,
        Afternoon,
        Evening,
        Night
    }
    public struct Struct1
    {
        public int x, y;
        public void Mypoint(int x,int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine(x+"  "+y);
        }
    }
}


namespace NullableTYpes
{
    class Program
    {
        static void Main2(string[] args)
        {
            int ? i = 130;
            i = null;
            int j=0;
            if (i != null)
                j = (int)i;
            else
                j = 20;
            Console.WriteLine(j);
            Console.WriteLine("===============");
            //j = i ?? 10;
           // Console.WriteLine(j);
            Console.WriteLine("===============");
            // if (i.HasValue)
            //     j = i.Value;
            j = i.GetValueOrDefault(1457);
            Console.WriteLine(j);
            Console.ReadLine();
        }
       
    }
}

namespace ArrayDEmo
{
    class Program
    {
        static void Main1(string[] args)
        {
            //int[] arr = new int[5];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("enter the {0} element", i);
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("===============");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("{0}th element= {1}", i, arr[i]);
            //}


            int[] arr1 = new int[5];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("enter the {0} element", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("===============");
            //Array.Clear(arr1, 0, 5); initialize with defaut values
           // Array.Copy(arr1,arr,3);
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine("{0}th element= {1}", i, arr1[i]);
            //}
            foreach(int x in arr1)
            {
                Console.WriteLine(x);
            }


           
            Console.ReadLine();
        }

    }
}

namespace ArrayDEmo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[3];
            arr[1] = new int[2];
            arr[2] = new int[4];
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("enter the {0} element of array {1}", j, i);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
              
            }
            Console.WriteLine("===============");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine(" {0} element of array {1} = {2}", i, j, arr[i][j]);
                    
                }

            }






            Console.ReadLine();
        }

    }
}