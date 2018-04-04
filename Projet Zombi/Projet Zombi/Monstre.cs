using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class Monstre : Employe
    {
        ///Attributs
        ///
        Attraction affectation;
        int cagnotte;

        ///Constructeurs
        ///
        public Monstre ( string nom, string prenom, Sexe sexe, string fonctionDansEntreprise, int matricule, Attraction affectation, int cagnotte )
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Sexe = sexe;
            this.FonctionDansEntreprise = fonctionDansEntreprise;
            this.Matricule = matricule;

            this.Affectation = affectation;
            this.Cagnotte = cagnotte;
        }
        
        ///Accesseurs
        ///
        public int Cagnotte { get => cagnotte; set => cagnotte = value; }
        internal Attraction Affectation { get => affectation; set => affectation = value; }

        ///Methodes
        ///
        public void AffecterAttraction ( Monstre monstre, Attraction attraction )
        {
            monstre.Affectation = attraction;
        }

        //TODO gaetan modifier cagnotte  
        //Si cagnotte > 50 -> barbe a papa
        //Si > 500 -> pouvoir disparaitre + lire enoncé


    }
}
