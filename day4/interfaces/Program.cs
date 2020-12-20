using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program
    {
        static void Main1(string[] args)
        {
            classA a = new classA();
            classB b = new classB();
            a.Delete();
            a.Insert();
            a.Update();
            Console.WriteLine("=================");
            IdbFunctions oIdb;
            oIdb = a;
            oIdb.Delete();
            oIdb = b;
            oIdb.Delete();
            Console.WriteLine("=================");
            ((IdbFunctions)a).Delete();
            ((IdbFunctions)b).Delete();
            Console.WriteLine("=================");
            InsertMethod(oIdb);
            Console.ReadLine();
        }
        public static void InsertMethod(IdbFunctions oIdb)
        {
            oIdb.Insert();
        }
    }
    public interface IdbFunctions
    {
        void Insert();
        void Update();
        void Delete();

    }
    public class classA : IdbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("Delete()");
        }

        public void Insert()
        {
            Console.WriteLine(" Insert()");
        }

        public void Update()
        {
            Console.WriteLine("Update()");
        }

        public void Display()
        {
            Console.WriteLine(" Display()");
        }
    }

    public class classB : IdbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("ClassB-Delete()");
        }

        public void Insert()
        {
            Console.WriteLine("ClassB- Insert()");
        }

        public void Update()
        {
            Console.WriteLine("ClassB-Update()");
        }

        public void Display()
        {
            Console.WriteLine("ClassB- Display()");
        }
    }

   
}

namespace interfaces2
{
    class Program
    {
        static void Main2(string[] args)
        {
            classA a = new classA();
            IfileFunctions Ifile ;
            Ifile = a;
            Ifile.Close();
            Ifile.Delete();
            Ifile.Open();

           
            Console.WriteLine("=================");
          
            Console.WriteLine("=================");
         
            Console.ReadLine();
        }
        public static void InsertMethod(IdbFunctions oIdb)
        {
            oIdb.Insert();
        }
    }
    public interface IdbFunctions
    {
        void Insert();
        void Update();
        void Delete();

    }
    public interface IfileFunctions
    {
        void Open();
        void Close();
        void Delete();
    }
    public class classA : IdbFunctions,IfileFunctions
    {
        public void Delete()
        {
            Console.WriteLine("Delete()");
        }

        public void Insert()
        {
            Console.WriteLine(" Insert()");
        }

        public void Update()
        {
            Console.WriteLine("Update()");
        }

        public void Display()
        {
            Console.WriteLine(" Display()");
        }

        void IfileFunctions.Open()
        {
            Console.WriteLine("Open()");
        }

        void IfileFunctions.Close()
        {
            Console.WriteLine("Close()");
        }

        void IfileFunctions.Delete()
        {
            Console.WriteLine("Ifilefunctions-DElete()");
        }
    }

    


}

namespace interfaces3
{
    class Program
    {
        static void Main(string[] args)
        {
            classA a = new classA();
           
            a.Delete();
            a.Insert();
            a.Update();
            a.Open();
            a.Close();
           
            Console.WriteLine("=================");
           
            Console.ReadLine();
        }
        
    }
    public interface IFilefunctions
    {
        void Open();
        void Close();
    }
    public interface IdbFunctions :IFilefunctions
    {
        void Insert();
        void Update();
        void Delete();

    }
    public class classA : IdbFunctions
    {
        public void Close()
        {
            Console.WriteLine(" Close()");
        }

        public void Delete()
        {
            Console.WriteLine(" Delete()");
        }

        public void Display()
        {
            Console.WriteLine(" Display()");
        }

        public void Insert()
        {
            Console.WriteLine(" Insert()");
        }

        public void Open()
        {
            Console.WriteLine(" Open()");
        }

        public void Update()
        {
            Console.WriteLine(" Update()");
        }
    }

   


}
