using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts1
{
    class classB
    {
        public void factorial()
        {
            int n = 5;
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of " + n + " " + fact);


        }
        public void evenodd()
        {
            int a = 6;
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " EVEN NO ");
                //  Console.ReadLine();
            }
            else
            {
                Console.WriteLine(a + " ODD NO ");
                // Console.ReadLine();
            }
        }

        public void pattern()
        {
            int i, j;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.WriteLine(" * ");
                }

            }
            Console.WriteLine();
        }
    }
}
