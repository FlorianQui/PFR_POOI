using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    abstract class Attraction
    {
        /////////////Vérifié 04-04-2018


        ///Attributs
        ///
        protected String nom, typeDeBesoin, typeMaintenance, typeBesoin;
        protected int identifiant, nbMonstreMini, nbEntrees;
        protected bool enService, enMaintenance, besoinSpecifique;
        protected List<Monstre> equipe;
        protected TimeSpan dureeMaintenance;

        ///Accesseurs
        ///
        public string Nom { get => nom; set => nom = value; }
        public string TypeDeBesoin { get => typeDeBesoin; set => typeDeBesoin = value; }
        public string TypeMaintenance { get => typeMaintenance; set => typeMaintenance = value; }
        public string TypeBesoin { get => typeBesoin; set => typeBesoin = value; }
        public int Identifiant { get => identifiant; set => identifiant = value; }
        public int NbMonstreMini { get => nbMonstreMini; set => nbMonstreMini = value; }
        public int NbEntrees { get => nbEntrees; set => nbEntrees = value; }
        public bool EnService { get => enService; set => enService = value; }
        public bool EnMaintenance { get => enMaintenance; set => enMaintenance = value; }
        public bool BesoinSpecifique { get => besoinSpecifique; set => besoinSpecifique = value; }
        public TimeSpan DureeMaintenance { get => dureeMaintenance; set => dureeMaintenance = value; }
        internal List<Monstre> Equipe { get => equipe; set => equipe = value; }

        ///Méthodes
        ///

        public void Afficher_Employes_Sur_Attraction()
        {
            foreach ( Employe employe in Equipe )
            {
                Console.WriteLine(employe.ToString());
            }
        }

        public void Afficher_Nb_Entrees()
        {
            Console.WriteLine("Nombre d'entrees : " + NbEntrees);
        }

        public void Mettre_Attraction_En_Maintenance(string typeMaintenance)
        {
            EnService = false;
            TypeMaintenance = typeMaintenance;
            EnMaintenance = true;
        }

        public void Mettre_Attraction_En_Maintenance_Pour( string typeMaintenance, TimeSpan duree )
        {
            EnService = false;
            TypeMaintenance = typeMaintenance;
            EnMaintenance = true;
            DureeMaintenance = duree;
        }

        public void Mettre_Attraction_En_Service()
        {
            EnMaintenance = false;
            EnService = true;
        }
        public override string ToString()
        {
            string result ="";
            if (enService == true)
            {
                result = "L'attraction " + nom + " avec l'identifiant " + identifiant + " est actuellement en service et a fait : " + nbEntrees + " entrés.";
            }
            else
            {
                result = "L'attraction " + nom + " avec l'identifiant " + identifiant + " n'est pas disponible mais a fait : " + nbEntrees + " entrés.";
            }
            return result;
        }
    }
}
