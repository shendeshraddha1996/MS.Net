namespace Assignment3Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[3];
            for(int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Enter the Details of Student {0} ;-", i+1);
                s[i] = new Student();
                s[i].getdata();
            }

            Console.WriteLine("==================");
            //show student data
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Details of Student {0} ",i+1);
                Console.WriteLine(" Name= {0}",s[i].name);
                Console.WriteLine("Roll NO= {0}",s[i].rollNo);
                Console.WriteLine("Marks= {0}", s[i].marks);
                Console.WriteLine("-------------------------");
            }

            Console.ReadLine();
        }
    }
    public struct Student
    {
        public string name;
        public  int rollNo;
        public  decimal marks;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                    name = value;
                else
                    Console.WriteLine("Invalid");
            }
        }
        public int RollNo
        {
            get
            {
                return rollNo;
            }
            set
            {
                if (value >0)
                    rollNo = value;
                else
                    Console.WriteLine("Invalid");
            }
        }
        public Student(string name, int rollNo, decimal marks)
        {
            this.name = name;
            this.marks = marks;
            this.rollNo = rollNo;
            this.Name = name;

        }
        public void getdata()
        {
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the marks");
            marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the roll no");
            rollNo = Convert.ToInt32(Console.ReadLine());
        }

    }

}