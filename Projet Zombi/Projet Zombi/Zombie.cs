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
            this.DegreDecomposition = degreDecomposition;
            this.CouleurZombie = couleurZombie;
        }

        ///Accesseurs
        ///
        public int DegreDecomposition { get => degreDecomposition; set => degreDecomposition = value; }
        public CouleurZombie CouleurZombie { get => couleurZombie; set => couleurZombie = value; }

        ///Methodes
        ///
        public void ModiferDegreDecomposition( int changement )
        {
            this.DegreDecomposition += changement;
        }

        public void ChangerDegreDecomposition ( int degre )
        {
            this.DegreDecomposition = degre;
        }

        public void ModifierCouleurZombie( CouleurZombie couleurZombie )
        {
            this.CouleurZombie = couleurZombie;
        }
    }
}
