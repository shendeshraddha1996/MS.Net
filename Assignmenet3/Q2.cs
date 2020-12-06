namespace Assignment3Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int batch,students;
            Console.WriteLine("Enter Number of batches");
            batch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("==================");
            int[][] arr = new int[batch][];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the number of students for batch {0}",i+1);
                students= Convert.ToInt32(Console.ReadLine());
                int[] marks = new int[students];  
               
                for(int j = 0; j <students; j++)
                {
                    Console.WriteLine("Enter the marks of  for Student {0}", j + 1);
                    marks[j]= Convert.ToInt32(Console.ReadLine());
                }
                arr[i] = marks;
                Console.WriteLine("==================");
            }
          //  Console.WriteLine("==================");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Marks of student of batch {0} : ", i);
                Console.WriteLine();
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("Marks of Student {0} = {1}",j+1, arr[i][j]);
                  
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

   
}