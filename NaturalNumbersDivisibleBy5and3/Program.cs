using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNumbersDivisibleBy5and3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum =0;
            for (int i = 1; i < 1000; i++)
            {
                if((i%3==0) || (i%5==0))
                {
                    Console.Write("  " +i);
                    sum = sum + i;
                }
            }
            Console.WriteLine("\n\nSum is: " +sum);
            Console.ReadKey();

        }
    }
}
