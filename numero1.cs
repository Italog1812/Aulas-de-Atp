using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            double n =1;
            double m =10;
            double soma = 0;
            string letra;
            Console.WriteLine("Digite qual letra da atividade 1 você deseja ver");
            letra = Console.ReadLine();
            switch(letra){
                case "a":
                    for (n = 0; n <= 50; n++)
                    {
                        soma += n;

                    }
                    Console.WriteLine("Letra a) " + soma);
                    break;
                case "b":
                    for (n = 1; n <= 10; n++)
                    {
                        soma += 1/n;

                    }
                    Console.WriteLine("Letra b) " + soma);
                    break;
                case "c":
                    for (n = 1; n <= 49; n+=2)
                    {
                        soma +=  n;

                    }
                    Console.WriteLine("Letra c) " + soma);
                    break;
                case "d":
                    for (n = 2; n <= 80; n+=2)
                    {
                        soma += n;

                    }
                    Console.WriteLine("Letra d) " + soma);
                    break;
                case "e":
                    while(n<=10)
                    {
                        soma += n / m;
                        m -= 1;
                        n += 1;                           
                    }
                    Console.WriteLine("Letra e) " + soma);
                    break;
                case "f":
                    for(n=-4;n<=24;n+=2)
                    {
                        soma += n;                      
                    }
                    Console.WriteLine("Letra f) " + soma);
                    break;
                case "g":
                    for (n = -5; n <= 31; n += 4)
                    {
                        soma += n;
                    }
                    Console.WriteLine("Letra g) " + soma);
                    break;

            }
            Console.ReadKey();
        } 

    }
}

