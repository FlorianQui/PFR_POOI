using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class DarkRide : Attraction
    {
        ///Attributs
        ///
        private TimeSpan duree;
        private bool vehicule;

        ///Constructeurs
        ///
        public DarkRide()
        {

        }
        public DarkRide(string nom, string typeDeBesoin, int identifiant, int nbMonstreMini, TimeSpan duree, bool vehicule)
        {
            this.Nom = nom;
            this.TypeDeBesoin = typeDeBesoin;
            this.Identifiant = identifiant;
            this.NbMonstreMini = nbMonstreMini;

            this.Equipe = new List<Monstre>();
            this.EnService = false;

            this.Duree = duree;
            this.Vehicule = vehicule;
        }

        ///Accesseurs
        ///
        public TimeSpan Duree { get => duree; set => duree = value; }
        public bool Vehicule { get => vehicule; set => vehicule = value; }
        public override string ToString()
        {
            string result = "";
            result = base.ToString() + " Infos complémentaire (durée,véhicule) :" + duree +", "+vehicule;
            return result;

        }
        ///Methodes
        ///

    }
}
