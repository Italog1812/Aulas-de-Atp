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
            double soma=0, media=0, a = 0;
            int i;
            Console.WriteLine("Programa para calcular a media de consumo daas 8 casas do bairro");
            for (i = 1; i <= 8; i++)
            {
                Console.WriteLine("Digite o consumo da casa");
                a = double.Parse(Console.ReadLine());
                soma += a;
            }
            media = soma / 8;
            Console.WriteLine("A media de consumo do bairro é: " + media);

            Console.ReadKey();
            }
            
        } 

    }

