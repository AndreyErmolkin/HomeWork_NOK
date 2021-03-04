using System;

namespace HomeWork_NOK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Число N=");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Число M=");
            int M = int.Parse(Console.ReadLine());

            int i;

            for (i = 0; i < (N * M) + 1; i++)
            {
                if (i % N == 0 && i % M == 0)
                {
                    int NOK = i;
                    if (i!=0)
                    {
                        Console.WriteLine("Наименьшее общее кратное = " + i);
                    }    

                }
            }
        }
    }
}
