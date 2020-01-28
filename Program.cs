using System;

namespace schooltuition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            double sum = 6000; 
            do
            {
                double x = sum;
                double y = x * .02;
                 sum = x + y;
                x = sum;


                Console.WriteLine($"Your tuition for year {n} is ${sum}.");
                n++;
            }

            while (n <= 5); 



            

            

            


        }
    }
}
