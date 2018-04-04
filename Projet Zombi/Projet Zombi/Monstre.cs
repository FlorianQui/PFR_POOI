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
        public void ChangerAffectation ( Attraction nouvelleAttraction )
        {
            if (this.Affectation.Equipe.Count() > this.Affectation.NbMonstreMini) this.Affectation = nouvelleAttraction;
            else Console.WriteLine("Impossible de changer l'affectation car l'equipe de l'attraction sera insufisante !");
        }
    }
}
