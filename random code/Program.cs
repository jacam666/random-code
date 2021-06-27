using System;

namespace random_code
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 8;
            //int b = ++ a;
            //if (a > 5)
            //    b -= 3;
            //else
            //    b = 9;
            //Console.WriteLine(b);

            int num = Convert.ToInt32(Console.ReadLine());


            //if (num == 1)
            //{
            //    Console.WriteLine("Easy");
            //}
            //if (num == 2)
            //{
            //    Console.WriteLine("Medium");
            //}
            //if (num == 3)
            //{
            //    Console.WriteLine("Hard");
            //}
            //if ( num >3)
            //{
            //    Console.WriteLine("Invalid option");
            //}
            //if (num < 1)
            //{
            //    Console.WriteLine("Invalid option");

            //}

            // using else if 
            if (num == 1)
            {
                Console.WriteLine("Easy");
            }
            else if (num == 2)
            {
                Console.WriteLine("Medium");
            }
            else if (num == 3)
            {
                Console.WriteLine("Hard");
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
           
           










        }
    }
}
