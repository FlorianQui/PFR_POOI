using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class LoupGarou : Monstre
    {
        ///Attributs
        ///
        double indiceCruaute;

        ///Constructeurs
        ///
        public LoupGarou(string nom, string prenom, Sexe sexe, string fonctionDansEntreprise, int matricule, Attraction affectation, int cagnotte, double indiceCruaute)
            : base(nom, prenom, sexe, fonctionDansEntreprise, matricule, affectation, cagnotte)
        {
            this.IndiceCruaute = indiceCruaute;
        }

        ///Accesseurs
        public double IndiceCruaute { get => indiceCruaute; set => indiceCruaute = value; }

        ///Methodes
        ///
    }
}
