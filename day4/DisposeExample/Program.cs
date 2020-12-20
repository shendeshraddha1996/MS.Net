using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            classA a = new classA();

          //  a.display();
           // a.Dispose();
           // a.display(); 
            Console.WriteLine("===================");
            using (classA b = new classA())
            {
                a.display();
            }
                Console.ReadLine();
        }
    }

    public class classA : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("calling Dispose()");
            IsDisposed = true;
        }
        public void display()
        {
            CheckForDisposed();
            Console.WriteLine("calling display()");
        }
        private bool IsDisposed = false;
        public void CheckForDisposed()
        {
            if (IsDisposed)
                throw new ObjectDisposedException("classA");
        }
    }
}
