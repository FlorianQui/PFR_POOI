using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.ComponentModel;

namespace Projet_Zombi
{
    class Program
    {
        static void Main(string[] args)
        {
            Parc parc = new Parc("Hello", "18 r", "peur", 20000);

            //parc.TrierParClasseEtCritere(parc.Personnel.Employes, "Nom", OrdreTrie.ASC);
            


            parc.PeuplementCSV();

            //parc.Personnel.AfficherListePersonnel();

            parc.EcrireListeVersCSV(parc.Personnel.Employes);

            parc.AfficherListe(parc.ListeParClasse(parc.Personnel.Employes, "Demon"));

            Console.ReadKey();
        }
    }
}
