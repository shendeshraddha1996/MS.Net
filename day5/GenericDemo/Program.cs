using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Program
    {
        static void Main1(string[] args)
        {
            MyOperations<int> mp = new MyOperations<int>();
            //mp.swap(ref 2, 3);
        }
    }

    public class  MyOperations<T>
    {
        public static void swap(ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
}
   
}

namespace CollectionExample
{
    class Program
    {
        static void Main2(string[] args)
        {
            ArrayList ar = new ArrayList();
           
            ar.Add(20);
            ar.Add(30);
            ar.Add(40);
            ar.Add(10);
            ar.Add(10);
            ar.Add(10);
            //ar.Capacity = 3;
            // ar.Remove(10);
            // ar.RemoveAt(0);
           // Console.WriteLine(ar.Contains(120)); 
           
            foreach (Object o in ar)
            {
                Console.WriteLine(o);
            }
            //ar.BinarySearch(0,4,);
           // Console.WriteLine(ar.Count());
                
                Console.ReadLine();
        }
    }

    
}

namespace CollectionExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable objDictionary = new Hashtable();
            SortedList objDictionary = new SortedList();
            objDictionary.Add(1, "shraddha");
            objDictionary.Add(2, "pravin");
            objDictionary.Add(3, "shebde");
            objDictionary[3] = "new value";
            objDictionary[4] = "shankar";
            //objDictionary.Remove(1);
            //objDictionary.RemoveAt(0);
            Console.WriteLine(objDictionary.GetByIndex(0));
            Console.WriteLine("-------------");
            foreach(DictionaryEntry de in objDictionary)
            {
                Console.WriteLine(de.Key);
                Console.WriteLine(de.Value);
            }

            Console.ReadLine();
        }
    }


}

