using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class Zombie : Monstre
    {
        int degreDecomposition;
        CouleurZombie couleurZombie;

        public Zombie(string nom, string prenom,
                            string adresse, Sexe sexe,
                            string fonctionDansEntreprise,
                            double salaire, int matricule, Attraction affectation, int cagnotte, int degreDecompostion, CouleurZombie couleurZombie)
                       : base(nom, prenom, adresse, sexe, fonctionDansEntreprise, salaire, matricule, affectation, cagnotte)
        {
            this.degreDecomposition = degreDecomposition;
            this.couleurZombie = couleurZombie;
        }
    }
}
