﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
abstract class Employe : IComparable
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

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }


        ///Méthodes
        ///


        ///ToString
        ///

        public override string ToString()
        {
            string result = "L'employe du personnel : ";

            if ( Sexe == Sexe.masculin )
            {
                result += "Monsieur ";
            }
            else
            {
                result += "Madame ";
            }

            result += Nom.ToUpper() + " " + prenom +
                        " travaille comme " + FonctionDansEntreprise +
                        " : Matricule || " + Matricule;

            return result;
        }

    }
}
