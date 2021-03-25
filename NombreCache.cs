using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Programme du nombre caché
              * Un joueur donne un nombre qu'il faut retrouver
              * Date : 25/03/2021
              * Auteur : Gwen */

            // Déclarations
            int nb = 0, essai, compteur = 1;
            bool correct = false;

            // Nombre à chercher
            while (!correct)
            {
                try
                {
                    Console.WriteLine("Entrez le nombre à chercher =");
                    nb = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Veuillez saisir un nombre.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            // Recherche du nombre
            Console.Clear();
            Console.WriteLine("Entrez un essai =");
            essai = int.Parse(Console.ReadLine());

            //Boucle pour trouver le nombre
            while (essai != nb)
            {
                if (essai > nb)
                {
                    Console.WriteLine("C'est trop grand !");
                }
                else
                {
                    Console.WriteLine("C'est trop petit !");
                }
                Console.WriteLine("Entrez un essai =");
                essai = int.Parse(Console.ReadLine());
                compteur++;
            }
            // Nombre trouvé
            Console.Clear();
            Console.WriteLine("Bravo vous avez trouver le bon nombre en " + compteur + " fois !");

            Console.ReadLine();
        }
    }
}
