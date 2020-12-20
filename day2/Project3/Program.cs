using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Inheritance
namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new BaseClass();
            DerivedClass d = new DerivedClass();
           
        }
    }

     public class BaseClass
    {
        public int a;
    }
    public class DerivedClass : BaseClass
    {
        public int b;
    }
}

namespace Inheritace1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new BaseClass();
        
           DerivedClass d = new DerivedClass();
         
        }
    }

    public class BaseClass
    {
        public int Public;
        private int Private;
        protected int Protected;
        internal int Intenal;
        protected internal int Protected_Intenal;
    }
    public class DerivedClass : Project3.BaseClass1   // BaseClass
    {
        public int b;
    }
}
