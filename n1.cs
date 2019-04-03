using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            int face;
            int cont1=0, cont2=0;
            Console.WriteLine("Atenção Dignissimo Usuario este programa contara a ocorrência de caras e coroas");
            Console.WriteLine("Caso cara digite 1/Caso coroa digite 2 e para para o rpograma digite 0");
            face = int.Parse(Console.ReadLine());
            if (face != 0)
            {
                if (face == 2)
                {
                    cont1++;
                }
                else if (face==1)
                {
                    cont1++;
                }
                else if(face!=1 && face != 2)
                {
                    Console.WriteLine("POR FAVOR DIGITE 1 OU 2 OU CASO NECESSARIO 0 PARA PARA O PROGRAMA");
                }
            }
            else
            {
                Console.WriteLine("Não foram registrados lançamentos");
            }
            while (face != 0)
            {
                Console.WriteLine("Caso cara digite 1/Caso coroa digite 2 e para para o rpograma digite 0");
                face = int.Parse(Console.ReadLine());
                if (face == 1)
                {
                    cont1++;
                }
                else if (face == 2)
                {
                    cont2++;
                }
                else if(face!=1 && face != 2 && face!=0)
                {
                    Console.WriteLine("POR FAVOR DIGITE 1 OU 2 OU CASO NECESSARIO 0 PARA PARA O PROGRAMA");
                }
            }
            Console.WriteLine("Foram registrados {0} caras e {1} coroas",cont1,cont2);
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
