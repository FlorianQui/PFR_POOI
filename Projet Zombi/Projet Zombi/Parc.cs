using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class Parc
    {
        ///Attributs
        ///

        String nom, addresse, themeParc;
        int capital;
        List<Employe> direction;
        List<Attraction> listeAttraction;
        Personnel listeEmployes;

        ///Constructeur
        ///
        public Parc( string nom, string addresse, string themeParc, int capital )
        {
            this.Nom = nom;
            this.Addresse = addresse;
            this.ThemeParc = themeParc;
            this.Capital = capital;
        }

        ///Accesseurs
        ///

        public string Nom { get => nom; set => nom = value; }
        public string Addresse { get => addresse; set => addresse = value; }
        public string ThemeParc { get => themeParc; set => themeParc = value; }
        public int Capital { get => capital; set => capital = value; }
        internal List<Employe> Direction { get => direction; set => direction = value; }
        internal List<Attraction> ListeAttraction { get => listeAttraction; set => listeAttraction = value; }
        internal Personnel ListeEmployes { get => listeEmployes; set => listeEmployes = value; }

        ///Méthodes
        ///

        public bool AjouterMembreDirection ( Employe employe )
        {
            bool result = false;

            if ( ! Direction.Contains(employe) )
            {
                Direction.Add(employe);
                result = true;
            }

            return result;
        }

        public bool LicencierMembreDirection ( Employe employe )
        {
            bool result = false;

            if ( Direction.Contains(employe) )
            {
                Direction.Remove(employe);
                result = true;
            }

            return result;
        }


        ///ToString
        ///

        public override string ToString()
        {
            string toString = "Parc";
            return toString;
        }
    }
}
