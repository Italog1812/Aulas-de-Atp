using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            double consumo, soma=0;
            double mc = 0, maior=0, menor=0;
            Console.WriteLine("Digite o consumo da residência caso deseje parar digite um numero negativo");
            consumo = double.Parse(Console.ReadLine());
            if (consumo >= 0)
            {
                maior = consumo;
                menor = consumo;
            } 
            if (consumo >= 0 )
            {
                soma += consumo;
            }
            while( consumo >= 0)
            {
                Console.WriteLine("Digite o consumo da residência");
                consumo = double.Parse(Console.ReadLine());
                if (consumo>=0) {
                    soma += consumo;
                }
                if (consumo > maior && consumo>=0)
                {
                    maior = consumo;
                }
                else if (consumo < menor && consumo>=0)
                {
                    menor = consumo;
                }
                i++;
            }
            mc = soma / i;
            Console.WriteLine("A média de consumo do bairro é {0}, foram analisadas {1} residências",mc,i);
            Console.WriteLine("O menor consumo analisado foi {0} e o maior foi {1}",menor,maior);
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
