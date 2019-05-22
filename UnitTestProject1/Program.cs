using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien de dés voulez vous lancer ?");
            int nbDés = int.Parse(Console.ReadLine());
            Console.WriteLine("A combien de faces ?");
            int nbFaces = int.Parse(Console.ReadLine());

            int resultFinal = 0;
            for (int i = 0; i < nbDés; i++)
            {
                Random random = new Random();
                resultFinal += random.Next(nbFaces) + 1;
            }

            Console.WriteLine("La somme de tous les lancers est : " + resultFinal);
        }
    }
}
