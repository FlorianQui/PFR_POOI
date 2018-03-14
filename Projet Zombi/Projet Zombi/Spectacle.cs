using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class Spectacle : Attraction
    {
        ///Attributs
        ///
        int nbPlaces;
        Salle salle;
        Reservation horaire;

        ///Constructeur
        ///
        public Spectacle(string nom, string type, int identifiant, int nbMonstreMini, Salle salle, Reservation horaire, int nbPlaces) : base ( nom, type, identifiant, nbMonstreMini )
        {
            this.NbPlaces = nbPlaces;
            this.Salle = salle;
            this.Horaire = horaire;
        }

        ///Accesseurs
        ///

        public int NbPlaces { get => nbPlaces; set => nbPlaces = value; }
        internal Salle Salle { get => salle; set => salle = value; }
        internal Reservation Horaire { get => horaire; set => horaire = value; }
    }
}
