using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projet_Zombi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello Zombi");
            Console.ReadKey();
            Parc parc = new Parc("Hello", "18 r", "peur", 20000);

            //Sorcier s = new Sorcier();

            parc.Personnel.AfficherListePersonnel();

            Console.ReadKey();
            parc.Personnel.AfficherListePersonnel();

            AjouterEmployeCSV();

            Console.ReadKey();
        }// coucou c'est gaetan les amis ! :)

        public static void AjouterEmployeCSV()
        {
            StreamReader streamReader = new StreamReader("Listing.csv");
            string line = streamReader.ReadLine();
            while (!streamReader.EndOfStream)
            {
                Console.WriteLine(line);
                line = streamReader.ReadLine();
            }
        }
    }
}
