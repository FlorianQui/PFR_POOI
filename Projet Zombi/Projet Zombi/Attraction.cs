using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    public enum TypeBoutique { Souvenir, BarbeAPapa, Nourriture };
    public enum TypeCategorie { Assise, Inverse, Bobsleigh };



    class Attraction
    {
        ///Attributs
        ///

        private String nom, type, typeMaintenancen, typeBesoin;
        private int identifiant, nbMonstreMini, nbEntrees;
        private bool enService, enMaintenance, besoinSpecifique;
        private List<Monstre> monstreDansLAttraction;
        private TimeSpan dureeMaintenance;

        ///Constructeur
        ///

        public Attraction(string nom, string type, int identifiant, int nbMonstreMini)
        {
            this.Nom = nom;
            this.Type = type;
            this.Identifiant = identifiant;
            this.NbMonstreMini = nbMonstreMini;

            MonstreDansLAttraction = new List<Monstre>();
        }

        ///Accesseurs
        ///

        public string Nom { get => nom; set => nom = value; }
        public string Type { get => type; set => type = value; }
        public string TypeMaintenance { get => typeMaintenance; set => typeMaintenance = value; }
        public int Identifiant { get => identifiant; set => identifiant = value; }
        public int NbMonstreMini { get => nbMonstreMini; set => nbMonstreMini = value; }
        public int NbEntrees { get => nbEntrees; set => nbEntrees = value; }
        public bool EnService { get => enService; set => enService = value; }
        public bool EnMaintenance { get => enMaintenance; set => enMaintenance = value; }
        public bool BesoinSpecifique { get => besoinSpecifique; set => besoinSpecifique = value; }
        public TimeSpan DureeMaintenance { get => dureeMaintenance; set => dureeMaintenance = value; }
        internal List<Monstre> MonstreDansLAttraction { get => monstreDansLAttraction; set => monstreDansLAttraction = value; }

        ///Méthodes
        ///

        public void Afficher_Employes_Sur_Attraction()
        {
            foreach ( Employe employe in MonstreDansLAttraction )
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
            EnService = true;
        }
    }
}
