using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class Zombie : Monstre
    {
        ///Attributs
        ///
        int degreDecomposition;
        CouleurZombie couleurZombie;

        ///Constructeurs
        ///
        public Zombie(string nom, string prenom, Sexe sexe, string fonctionDansEntreprise, int matricule, Attraction affectation, int cagnotte, int degreDecomposition, CouleurZombie couleurZombie)
            : base(nom, prenom, sexe, fonctionDansEntreprise, matricule, affectation, cagnotte)
        {
            this.degreDecomposition = degreDecomposition;
            this.couleurZombie = couleurZombie;
        }

        ///Methodes
        ///

    }
}
