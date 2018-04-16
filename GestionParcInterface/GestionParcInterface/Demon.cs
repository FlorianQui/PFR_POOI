using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInterface
{
    class Demon : Monstre
    {
        ///Attributs
        ///
        int force;

        ///Constructeurs
        ///
        public Demon()
        {

        }
        public Demon(string nom, string prenom, Sexe sexe, string fonctionDansEntreprise, int matricule, Attraction affectation, int cagnotte, int force)
            : base(nom, prenom, sexe, fonctionDansEntreprise, matricule, affectation, cagnotte)
        {
            this.Force = force;
        }

        ///Accesseurs
        ///
        public int Force { get => force; set => force = value; }

        ///Methodes
        ///
        public override string ToString()
        {
            string result = "";
            result = base.ToString() + " possède une force de " + force;
            return result;
        }
        public void ChangerForce( int force )
        {
            this.Force = force;
        }

        public void ModifierForce( int changement )
        {
            this.Force += changement;
        }
    }
}
