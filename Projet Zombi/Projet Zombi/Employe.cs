using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class Employe
    {
        ///Attributs
        ///

        string nom, adresse, sexe, fonctionDansEntreprise;
        double salaire;
        int matricule;

        ///Constructeur
        ///

        public Employe(string nom, string adresse, string sexe, 
                            string fonctionDansEntreprise, 
                            double salaire, int matricule)
        {
            this.Nom = nom;
            this.Adresse = adresse;
            this.Sexe = sexe;
            this.FonctionDansEntreprise = fonctionDansEntreprise;
            this.Salaire = salaire;
            this.Matricule = matricule;
        }

        ///Accesseurs
        ///

        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Sexe { get => sexe; set => sexe = value; }
        public string FonctionDansEntreprise { get => fonctionDansEntreprise; set => fonctionDansEntreprise = value; }
        public double Salaire { get => salaire; set => salaire = value; }
        public int Matricule { get => matricule; set => matricule = value; }


    }
}
