using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class Dice
    {

        public int nbFaces { get; set; }

        public Dice()
        {
            this.nbFaces = 6;
        }
        public Dice(int nbFaces)
        {
            this.nbFaces = nbFaces;
        }

        public int ThrowDice()
        {
            // METHODE POUR LANCER UN DE UNIQUE
            int result = 0;          
            Random random = new Random();
            result += random.Next(1, nbFaces);
            return result;
        }
    }
}
