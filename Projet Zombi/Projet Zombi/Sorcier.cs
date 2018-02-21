using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{ 
    class Sorcier : Employe
    {
        ///Attributs
        ///

        string tatouage;
        List<Pouvoir> pouvoirs;

        ///Constructeur
        ///

        public Sorcier(string nom, string prenom, Sexe sexe, string fonctionDansLEntreprise, double salaire, int matricule, string tatouage, List<Pouvoir> pouvoirs) 
                      : base(nom, prenom, adresse, sexe, fonctionDansLEntreprise, salaire, matricule)
        {
            this.Tatouage = tatouage;
            this.Pouvoirs = pouvoirs;
            pouvoirs = new List<Pouvoir>();
        }

        ///Accesseurs
        ///

        public string Tatouage { get => tatouage; set => tatouage = value; }
        public List<Pouvoir> Pouvoirs { get => pouvoirs; set => pouvoirs = value; }
    }
}
