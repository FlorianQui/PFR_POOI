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
        public Spectacle(string nom, string typeDeBesoin, int identifiant, int nbMonstreMini, Salle salle, Reservation horaire, int nbPlaces)
        {
            this.Nom = nom;
            this.TypeDeBesoin = typeDeBesoin;
            this.Identifiant = identifiant;
            this.NbMonstreMini = nbMonstreMini;
            this.NbPlaces = nbPlaces;
            this.Salle = salle;
            this.Horaire = horaire;

            this.Equipe = new List<Monstre>();
            this.EnService = false;
        }

        ///Accesseurs
        ///
        public int NbPlaces { get => nbPlaces; set => nbPlaces = value; }
        internal Salle Salle { get => salle; set => salle = value; }
        internal Reservation Horaire { get => horaire; set => horaire = value; }

        ///Methodes
        ///
        public bool SpectacleAccepte()
        {
            // TODO si pas salle ni reservation => false
            return true;
        }
    }
}
