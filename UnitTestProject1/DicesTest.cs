using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class DicesTest
    {

        [TestMethod]
        public void SyntaxeXdY()
        {
            // Méthode pour tester la syntaxe de l'entrée utilisateur XdY

            InputParser ipp = new InputParser();
            
            string requeteUtilisateur = "4d10";
            Assert.IsTrue(ipp.checkSyntax);

            Boolean correctSyntax = true;

            if (requeteUtilisateur.Contains("d"))
            {
                string[] splitString = requeteUtilisateur.Split('d');

                int n1;
                int n2;
                bool isNumeric1 = int.TryParse(splitString[0], out n1);
                bool isNumeric2 = int.TryParse(splitString[1], out n2);

                if (isNumeric1 && isNumeric2)
                {
                }
                else
                {
                    Console.WriteLine("X et/ou Y ne sont pas des nombres.");
                    correctSyntax = false;
                }
            }
            else
            {
                Console.WriteLine("La syntaxe n'est pas correcte");
                correctSyntax = false;
            }
        }
        [TestMethod]
        public void LimitesX()
        {
            // Méthode pour tester les limites de X le nombre de dés qui doit être compris entre 0 et 100
            string entreeUtilisateur1 = "100d100";
            string entreeUtilisateur2 = "102d100";

            InputParser ipp = InputParser();
            Assert.IsTrue(ipp.checkDices(entreeUtilisateur1));
            Assert.IsFalse(ipp.checkDices(entreeUtilisateur2), "Le nombre de dés à lancer d'un coup doit être compris entre 0 et 100");
        }

        [TestMethod]
        public void LimitesY()
        {
            // Méthode pour tester les limites de Y, le nombre de faces qui doit être compris entre 2 et 100
            string entreeUtilisateur1 = "100d10";
            string entreeUtilisateur2 = "100d1";


            InputParser ipp = InputParser();
            Assert.IsTrue(ipp.checkFaces(entreeUtilisateur1));
            Assert.IsFalse(ipp.checkFaces(entreeUtilisateur2), "Le nombre de faces des dés à lancer doit être compris entre 2 et 100");
        }

        [TestMethod]
        public void DeParDefaut()
        {
            // Méthode pour tester le retour de la somme des résultats de chaque dé
            string entreeUtilisateur = "";

            if (entreeUtilisateur.Equals(""))
            {
                Dice defaultDice = new Dice();
                Assert.IsTrue(defaultDice.nbFaces == 6);
            }
        }



        [TestMethod]
        public void MyTestMethod()
        {

        }





        public int ThrowDices(int X, int Y)
        {
            int finalResult = 0;

            string entreeUtilisateur = "100d100";

            string[] splitString = entreeUtilisateur.Split('d');

            int nbDes = int.Parse(splitString[0]);
            int nbFaces = int.Parse(splitString[1]);

            for (int i = 0; i <= X; i++)
            {
                Dice nextDice = new Dice(Y);
                finalResult += nextDice.ThrowDice();
            }


            return finalResult;
        }

        public int ThrowDices()
        {
            Dice defaultDice = new Dice();
            Random random = new Random();
            int finalresult = random.Next(1, defaultDice.nbFaces);
            return finalresult;
        }
    }
}
