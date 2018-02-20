using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    public enum Sexe { Masculin, Feminin };

    class Employe
    {
        ///Attributs
        ///
        private Sexe sexe;
        private string nom, prenom ,adresse, fonctionDansEntreprise;
        private double salaire;
        private int matricule;

        ///Constructeur
        ///

        public Employe(string nom, string prenom, 
                            string adresse, Sexe sexe, 
                            string fonctionDansEntreprise, 
                            double salaire, int matricule)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Adresse = adresse;
            this.Sexe = sexe;
            this.FonctionDansEntreprise = fonctionDansEntreprise;
            this.Salaire = salaire;
            this.Matricule = matricule;
        }

        ///Accesseurs
        ///

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public Sexe Sexe { get => sexe; set => sexe = value; }
        public string FonctionDansEntreprise { get => fonctionDansEntreprise; set => fonctionDansEntreprise = value; }
        public double Salaire { get => salaire; set => salaire = value; }
        public int Matricule { get => matricule; set => matricule = value; }

        ///Méthodes
        ///
        

        ///ToString
        ///

        public override string ToString()
        {
            string toString = "L'employe du personnel : ";

            if ( Sexe == Sexe.Masculin )
            {
                toString += "Monsieur ";
            }
            else
            {
                toString += "Madame ";
            }

            toString += Nom.ToUpper() + " " + prenom +
                        "\n     habite au " +
                        Adresse + " travaille comme " +
                        FonctionDansEntreprise +
                        " avec un salaire de " + Salaire +
                        " : Matricule || " + Matricule;

            return toString;
        }

    }
}
