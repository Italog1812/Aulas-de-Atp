using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipo;
            double cr, cc, mr,mc,mb;
            double cont1 = 0, cont2 = 0, cont3 = 0, cont4= 0; 
            Console.WriteLine("Atenção Dignissimo Usuario este programa ira calcular diversas coisas do consumo do bairro");
            Console.WriteLine("Caso residência digite 1/Caso comercio digite 2 e para para o programa digite 0");
            tipo = int.Parse(Console.ReadLine());
            if (tipo != 0)
            {
                if (tipo == 1)
                {
                    cont1++;
                    Console.WriteLine("Digite o consumo de sua residência");
                    cr = double.Parse(Console.ReadLine());
                    cont3 += cr;
                }
                else if (tipo == 2)
                {
                    cont2++;
                    Console.WriteLine("Digite o consumo de seu comercio");
                    cc = double.Parse(Console.ReadLine());
                    cont4 += cc;
                }
                else if (tipo != 1 && tipo != 2 && tipo != 0)
                {
                    Console.WriteLine("POR FAVOR DIGITE 1 OU 2 OU CASO NECESSARIO 0 PARA PARA O PROGRAMA");
                }
            }
            else
            {
                Console.WriteLine("Não foram registrados locais");
            }
            while (tipo != 0)
            {
                Console.WriteLine("Caso residência digite 1/Caso comercio digite 2 e para para o rpograma digite 0");
                tipo = int.Parse(Console.ReadLine());
                if (tipo == 1)
                {
                    cont1++;
                    Console.WriteLine("Digite o consumo de sua residência");
                    cr = double.Parse(Console.ReadLine());
                    cont3 += cr;
                }
                else if (tipo == 2)
                {
                    cont2++;
                    Console.WriteLine("Digite o consumo de seu comercio");
                    cc = double.Parse(Console.ReadLine());
                    cont4 += cc;
                }
                else if (tipo != 1 && tipo != 2 && tipo != 0)
                {
                    Console.WriteLine("POR FAVOR DIGITE 1 OU 2 OU CASO NECESSARIO 0 PARA PARA O PROGRAMA");
                }
            }
            Console.WriteLine("Foram registrados {0} Residências e {1} comercios", cont1, cont2);
            mr = cont3 / cont1;
            mc = cont4 / cont2;
            mb = (cont3 + cont4) / (cont1 + cont2);
            Console.WriteLine("Media de consumo das residências {0}",mr);
            Console.WriteLine("Media de consumo dos comercios {0}", mc);
            Console.WriteLine("Media de consumo do bairro {0}", mb);
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
