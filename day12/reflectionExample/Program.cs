using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace reflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFile(@"C:\Users\shradhha shende\source\repos\day12_1\reflectionExample\Class1.cs");
            Type t = asm.GetType(asm.GetName().Name + ".TaxCalculator", true, true);
            object obj = Activator.CreateInstance(t);
            PropertyInfo p = t.GetProperty("Basic");
            p.SetValue(obj,10000M,null);
            Console.WriteLine(p.GetValue(obj,null).ToString());
            MethodInfo m = t.GetMethod("GetNetSalary");
            decimal NetSal = (decimal)m.Invoke(obj, null);
            Console.WriteLine(NetSal.ToString());
        }
    }
}
