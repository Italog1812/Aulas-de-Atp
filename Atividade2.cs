using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 1;
            double a, maior, menor;  
            double soma=0, media = 0;
            Console.WriteLine("Programa feito para mostrar o menor numero, o maior numero e a média dos numeros dos 7 numeros que serãon digitados");
            Console.WriteLine("Por favor imforme um numero");
            a = double.Parse(Console.ReadLine());
            menor = a;
            maior = a;
            soma += a;
            while (i <= 6)
            {
                Console.WriteLine("Por favor imforme um numero: ");
                a = double.Parse(Console.ReadLine());
                soma += a;
                if (a > maior)
                {
                    maior = a;
                }else if (a < menor)
                {
                    menor = a;
                }
                i++;
            }
            media = soma / 7;
            Console.WriteLine("O maior é:"+ maior);
            Console.WriteLine("O menor é:" + menor);
            Console.WriteLine("A média é:" + media);
            Console.ReadKey();

            //	   _    _____         _
            //	   \`,""   ,'7"r-..__/ \
            //	  ,'\ `, ,',','    _/   \
            //	 /   \  7 / /     (   \ |
            //	J     \/ j  L______\  / |
            //	L   __JF"""/""\"\_,    /
            //	L,-"| O|  f O |  L_  _/
            //	F   \_ /  \__/   `-  j|
            //		.-'    `"""    ,' |          _..====.._
            //		\__/         r"_  A        ,' _..---.._`,
            //		 `-.______,,-L// / \  ___,' ,'_..:::.. `,`,
            //				  j   / / / 7"    `-<""=:'  '':. \ \
            //				 /   <,' /  F  . i , \   `,    :T W I
            //				 |    \,'  /    >X<  |     \   :| | L
            //				 |     `._/    ' ! ` |      I  :| |  G
            //				  \           \     /       |  :H T  |
            //				 __>-.__   __,-\   |        |  S P   |
            //				/     /|   | \  \  \_       | 'A R   |
            //			   /   __/ |   |  L  L   \      K./ /    L
            //			  /   |    |   4  I  I    |    E./ /   ,'
            //			 J    \    I    L F  I    |    // / _,'
            //	_________|     |   F    |J   F    |   //_/-'
            //	\   __   |    /   J     |/  J     |  /="
            //	\\  \_\  \__,' \  F     |   F     |
            //	\\\_____________\/      F__/      F
            //	 \\|  HTML for  |_____/  (______/
            //	  \/__Dummies___/
            //           
        }
    }
}
