using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            double b=65000000, a = 80000000;
            double i = 0;
            while (b < a) 
            {
                Console.WriteLine("Cidade a: "+ a);
                Console.WriteLine("Cidade b: " + b);
                b = b * 1.03;
                a = a * 1.015;
                i++;
            }
            Console.WriteLine("Foram {0} anos para a cida de b passar a cidade a",i);
            Console.ReadKey();
        }
    }
}
