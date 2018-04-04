using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class Salle
    {
        ///Attributs
        ///

        private string nom;
        private int nbPlaces;
        private List<Reservation> calendrier;

        ///Constructeur
        ///

        public Salle(string nom, int nbPlaces)
        {
            this.Nom = nom;
            this.NbPlaces = nbPlaces;
            Calendrier = new List<Reservation>();
        }

        ///Acceseurs
        ///

        public string Nom { get => nom; set => nom = value; }
        public int NbPlaces { get => nbPlaces; set => nbPlaces = value; }
        internal List<Reservation> Calendrier { get => calendrier; set => calendrier = value; }

        ///Méthodes
        ///

        public bool AnnulerReservation ( Reservation reservation )
        {
            bool result = false;

            if ( Calendrier.Contains(reservation) )
            {
                Calendrier.Remove(reservation);
                result = true;
            }

            return result;

            public override string ToString()
        {
            string result = "";
            result = "La salle "+nom+"possède "+nbPlaces+"places et peux être réservée selon un calendrier.";
            return result;

        }

    }
    }
}
