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
        public override string ToString()
        {
            string result = "";
            result = base.ToString() + " il possède un indice de cruauté de "+ indiceCruaute;
            return result;
        }
        public void ChangerIndiceCruaute( double indice )
        {
            this.IndiceCruaute = indice;
        }

        public void ModifierIndiceCruaute ( double changement )
        {
            this.IndiceCruaute += changement;
        }
    }
}
