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

            if (!this.Salle.Calendrier.Contains(horaire)) this.Horaire = horaire;
            else Console.WriteLine("Plage horaire déjà occupée !");

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
            // TODO gaetan si pas salle ni reservation => false
            return true;
        }
        public override string ToString()
        {
            string result = "";
            result = base.ToString()+"Elle possède "+NbPlaces+" places";
            return result;

        }

        public void ChangerSalle( Salle nouvelleSalle )
        {
            if (!nouvelleSalle.Calendrier.Contains(this.Horaire)) this.Salle = nouvelleSalle;
            else Console.WriteLine("Impossible de changer la plage horaire car elle est deja reservee !");
        }

        public void ChangerHoraire(DateTime heureDebut, DateTime heureFin)
        {
            Reservation reservation = new Reservation(heureDebut, heureFin);

            if (!this.Salle.Calendrier.Contains(reservation)) this.Horaire = reservation;
            else Console.WriteLine("Plage horaire déjà occupée !");
        }
    }
}
