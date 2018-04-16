using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInterface
{
    class Fantome : Monstre
    {
        ///Attributs
        ///

        ///Constructeurs
        ///
        public Fantome()
        {

        }
        public Fantome(string nom, string prenom, Sexe sexe, string fonctionDansEntreprise, int matricule, Attraction affectation, int cagnotte)
            : base(nom, prenom, sexe, fonctionDansEntreprise, matricule, affectation, cagnotte)
        {
        }

        ///Methodes
        ///
        public override string ToString()
        {
            string result = "";
            result = base.ToString();
            return result;

        }
    }
}
