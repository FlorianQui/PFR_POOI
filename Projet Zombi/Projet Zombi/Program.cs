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

            Monstre m1 = new Monstre("ok", "kk", Sexe.masculin, "o", 99, null, 99);
            Monstre m2 = new Monstre("aa", "kk", Sexe.masculin, "o", 99, null, 99);

            parc.Personnel.Employes.Add(m1);
            parc.Personnel.Employes.Add(m2);

            parc.TrierParClasseEtCritere(parc.Personnel.Employes, "Nom", OrdreTrie.ASC);
            parc.EcrireListeVersCSV(parc.Personnel.Employes);

            parc.PeuplementCSV();

            parc.Personnel.AfficherListePersonnel();

            Console.ReadKey();
        }
    }
}
