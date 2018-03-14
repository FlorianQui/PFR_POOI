using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class Fantome : Monstre
    {
        public Fantome(string nom, string prenom,
                            string adresse, Sexe sexe,
                            string fonctionDansEntreprise,
                            double salaire, int matricule, Attraction affectation, int cagnotte)
                       : base(nom, prenom, adresse, sexe, fonctionDansEntreprise, salaire, matricule, affectation, cagnotte)
        {

        }
    }
}
