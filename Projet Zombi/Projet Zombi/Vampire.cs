using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class Vampire : Monstre
    {
        ///Attributs
        ///
        float indeceLuminosite;

        ///Constructeur
        ///
        public Vampire(string nom, string prenom,
                            string adresse, Sexe sexe,
                            string fonctionDansEntreprise,
                            double salaire, int matricule, Attraction affectation, int cagnotte, float indiceLuminosite)
                       : base (nom, prenom, adresse, sexe, fonctionDansEntreprise, salaire, matricule, affectation,cagnotte)
        {
            this.indeceLuminosite = indeceLuminosite;
        }
    }
}
