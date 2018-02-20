using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class Attraction
    {
        ///Attributs
        ///

        String nom, type, typeMaintenance;
        int identifiant, dureeMaintenance, nbMonstreMini;
        bool enService, enMaintenance;
        List<Employe> employeDansLAttraction;

        ///Constructeur
        ///

        public Attraction(string nom, string type, int identifiant, int nbMonstreMini)
        {
            this.Nom = nom;
            this.Type = type;
            this.Identifiant = identifiant;
            this.NbMonstreMini = nbMonstreMini;
        }

        ///Accesseurs
        ///

        public string Nom { get => nom; set => nom = value; }
        public string Type { get => type; set => type = value; }
        public string TypeMaintenance { get => typeMaintenance; set => typeMaintenance = value; }
        public int Identifiant { get => identifiant; set => identifiant = value; }
        public int DureeMaintenance { get => dureeMaintenance; set => dureeMaintenance = value; }
        public int NbMonstreMini { get => nbMonstreMini; set => nbMonstreMini = value; }
        public bool EnService { get => enService; set => enService = value; }
        public bool EnMaintenance { get => enMaintenance; set => enMaintenance = value; }
        internal List<Employe> EmployeDansLAttraction { get => employeDansLAttraction; set => employeDansLAttraction = value; }

        ///Méthodes
        ///

        public void Afficher_Employes_Sur_Attraction()
        {
            foreach ( Employe employe in employeDansLAttraction )
            {
                Console.WriteLine(employe.ToString());
            }
        }
    }
}
