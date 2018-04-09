using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Projet_Zombi
{
    class Program
    {
        static void Main(string[] args)
        {
            Parc parc = new Parc("Hello", "18 r", "peur", 20000);

            //1
            parc.PeuplementCSV();
            

            //2
            //parc.AjouterEmployeDuPersonnel(new Demon() );

            //3
            //Zombie z = (Zombie) parc.Personnel.Employes.Find(x => x.Nom == "Cabanis");
            //z.ChangerDegreDecomposition(3);
            //Console.WriteLine(z.ToString());
            //RollerCoaster rollerCoaster = (RollerCoaster)parc.ListeAttraction[3];
            //parc.ListeAttraction[3].Mettre_Attraction_En_Maintenance("revision");

            //Console.WriteLine(parc.ListeAttraction[3].ToString());

             //parc.ListeAttraction[3].Mettre_Attraction_En_Service();
            //Console.WriteLine(parc.ListeAttraction[3].ToString());

            //4
            
            Console.WriteLine();
            //parc.TrierParCritere(parc.ListeAttraction, "enMaintenance", OrdreTrie.ASC);
            //parc.AfficherListe( parc.ListeAttraction);

            List<Attraction> list = parc.Query(parc.ListeAttraction, "NbEntrees", 0);

            parc.AfficherListe(list);
            
            parc.EcrireListeVersCSV(parc.Personnel.Employes);

            parc.

            Console.ReadKey();
        }
    }
}  
