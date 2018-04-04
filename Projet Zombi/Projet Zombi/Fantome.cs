using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class Fantome : Monstre
    {
        ///Attributs
        ///

        ///Constructeurs
        ///
        public Fantome(string nom, string prenom, Sexe sexe, string fonctionDansEntreprise, int matricule, Attraction affectation, int cagnotte)
            : base(nom, prenom, sexe, fonctionDansEntreprise, matricule, affectation, cagnotte)
        {
        }

        ///Methodes
        ///

    }
}
