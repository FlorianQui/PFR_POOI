﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInterface
{
    class Vampire : Monstre
    {
        ///Attributs
        ///
        double indiceLuminosite;

        ///Constructeurs
        ///
        public Vampire()
        {

        }
        public Vampire(string nom, string prenom, Sexe sexe, string fonctionDansEntreprise, int matricule, Attraction affectation, int cagnotte, double indiceLuminosite) 
            : base (nom, prenom, sexe, fonctionDansEntreprise, matricule, affectation, cagnotte)
        {
            this.IndiceLuminosite = indiceLuminosite;
        }

        ///Accesseurs
        ///
        public double IndiceLuminosite { get => indiceLuminosite; set => indiceLuminosite = value; }

        ///Methodes
        ///
        public override string ToString()
        {
            string result = "";
            result = base.ToString() + " possède un indice de luminosité " + indiceLuminosite;
            return result;
        }

        public void ChangerIndiceLuminosite( double indice )
        {
            this.IndiceLuminosite = indice;
        }

        public void ModifierIndiceLuminosite( double changement )
        {
            this.IndiceLuminosite += changement;
        }
    }
}
