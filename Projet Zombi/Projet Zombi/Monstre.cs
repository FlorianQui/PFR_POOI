using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    abstract class Monstre : Employe
    {
        ///Attributs
        ///
        Attraction affectation;
        int cagnotte;

        ///Constructeurs
        ///
        public Monstre ( string nom, string prenom,
                            string adresse, Sexe sexe,
                            string fonctionDansEntreprise,
                            double salaire, int matricule, Attraction affectation, int cagnotte )
                       : base ( nom, prenom, adresse, sexe, fonctionDansEntreprise, salaire, matricule )
        {
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

    }
}
