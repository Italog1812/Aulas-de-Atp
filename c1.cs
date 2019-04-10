using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatura, media=0, maior, menor, n, i, soma=0;
            Console.WriteLine("Quantas temperaturas serão digitadas?");
            n = double.Parse(Console.ReadLine());
            Console.Write("Digite uma teperatura: ");
            temperatura = double.Parse(Console.ReadLine());
            menor = temperatura;
            maior = temperatura;
            soma += temperatura;
            for (i = 1; i < n; i++)
            {
                Console.Write("Digite uma teperatura: ");
                temperatura = double.Parse(Console.ReadLine());
                soma += temperatura;
                if (temperatura < menor)
                {
                    menor = temperatura;
                }
                else if (temperatura>maior)
                {
                    maior = temperatura;
                }
            }
            media = soma / i;
            Console.WriteLine("A menor temperatura é {0} e a maior é {1}, a média da temperatura é {2}",menor,maior,media);
            Console.ReadKey();
        }
    }
}
