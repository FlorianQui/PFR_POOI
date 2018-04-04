using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
abstract class Employe
    {
        ///Attributs
        ///
        protected Sexe sexe;
        protected string nom, prenom, fonctionDansEntreprise;
        protected int matricule;

        ///Accesseurs
        ///
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public Sexe Sexe { get => sexe; set => sexe = value; }
        public string FonctionDansEntreprise { get => fonctionDansEntreprise; set => fonctionDansEntreprise = value; }
        public int Matricule { get => matricule; set => matricule = value; }

        ///Méthodes
        ///
        

        ///ToString
        ///

        public override string ToString()
        {
            string toString = "L'employe du personnel : ";

            if ( Sexe == Sexe.masculin )
            {
                toString += "Monsieur ";
            }
            else
            {
                toString += "Madame ";
            }

            toString += Nom.ToUpper() + " " + prenom +
                        " travaille comme " + FonctionDansEntreprise +
                        " avec un salaire de " + Salaire +
                        " : Matricule || " + Matricule;

            return toString;
        }

    }
}
