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
            Parc parc = new Parc("Zombillenieum", "18 rue de la peur", "peur", 2000000);
            Console.WriteLine(" Logiciel de gestion du parc Zombillenium ");
            Console.WriteLine("__________________________________________");
            //1
            Console.WriteLine("Peuplement via csv :");
            parc.PeuplementCSV();

            Console.ReadKey();
            Console.Clear();

            //2
            Console.WriteLine("Ajout d'un Demon (Alastor Goderoi).  ");
            Demon d = new Demon("Alastor", "Goderoi", Sexe.autre, "ok", 19, null, 0, 0);
            parc.AjouterEmployeDuPersonnel(d);
            Console.WriteLine("Ajout d'un RollerCoaster (Aerosmith).  ");
            RollerCoaster r = new RollerCoaster("Aerosmith ", "aucun", 12, 5, 8, 120, TypeCategorie.bobsleigh);
            parc.AjoutAttraction(r);

            Console.ReadKey();
            Console.Clear();

            //3
            Console.WriteLine("Recherche d'un zombie dont le nom est Cabanis : \n");
            Zombie z = (Zombie) parc.Personnel.Employes.Find(zombie => zombie.Nom == "Cabanis");
            Console.WriteLine(z.ToString());
            Console.WriteLine(" \n Changement de son degre de decomposition en 3 : \n");
            z.ChangerDegreDecomposition(3);
            Console.WriteLine(z.ToString());

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Mise en maintenance d'une attraction pour motif  'revision' : \n");
            RollerCoaster rollerCoaster = (RollerCoaster) parc.ListeAttraction[3];
            rollerCoaster.Mettre_Attraction_En_Maintenance("revision");
            Console.WriteLine(parc.ListeAttraction[3].ToString());

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Mise en service d'une attraction en maintenance.");
            parc.ListeAttraction[3].Mettre_Attraction_En_Service();
            Console.WriteLine(parc.ListeAttraction[3].ToString());

            Console.ReadKey();
            Console.Clear();


            //4
            Console.WriteLine("Trie de la liste des attractions en Maintenance par ordre croissant. \n");
            Console.WriteLine("Mise en service d'une attraction en maintenance. \n");
            rollerCoaster.Mettre_Attraction_En_Maintenance("revision");

            parc.TrierParCritere(parc.ListeAttraction, "EnMaintenance", OrdreTrie.ASC);
            parc.AfficherListe(parc.ListeAttraction);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Affichage de la liste des monstres du parc : \n ");
            parc.AfficherListe(parc.ListeParClasse(parc.Personnel.Employes, "Monstre"));

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Affichage de la liste des zombies en fonction de leur cagnotte par ordre croissant : \n");
            List<Employe> list = parc.ListeParClasse(parc.Personnel.Employes, "Zombie");
            var query = from x in list
                        orderby ((Monstre)x).Cagnotte
                        select x;

            parc.AfficherListe(query.ToList());

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ecriture de la liste des monstres dans un csv");
            parc.EcrireListeVersCSV(parc.ListeParClasse(parc.Personnel.Employes, "Fantome"));

            Console.ReadKey();
            Console.Clear();
        }
    }
}  
