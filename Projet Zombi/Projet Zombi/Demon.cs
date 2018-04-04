using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class Demon : Monstre
    {
        ///Attributs
        ///
        int force;

        ///Constructeurs
        ///
        public Demon(string nom, string prenom, Sexe sexe, string fonctionDansEntreprise, int matricule, Attraction affectation, int cagnotte, int force)
            : base(nom, prenom, sexe, fonctionDansEntreprise, matricule, affectation, cagnotte)
        {
            this.Force = force;
        }

        ///Accesseurs
        ///
        public int Force { get => force; set => force = value; }

        ///Methodes
        ///

    }
}
