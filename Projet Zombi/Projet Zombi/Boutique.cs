using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class Boutique : Attraction
    {
        ///Attributs
        ///
        private TypeBoutique typeBoutique;

        ///Constructeur
        ///
        public Boutique(string nom, string typeDeBesoin, int identifiant, int nbMonstreMini, TypeBoutique typeBoutique)
        {
            this.Nom = nom;
            this.TypeDeBesoin = typeDeBesoin;
            this.Identifiant = identifiant;
            this.NbMonstreMini = nbMonstreMini;
            this.TypeBoutique = typeBoutique;

            this.Equipe = new List<Monstre>();
            this.EnService = false;
        }

        ///Accesseurs
        ///
        public TypeBoutique TypeBoutique { get => typeBoutique; set => typeBoutique = value; }
        public override string ToString()
        {
            string result = "";
            result = base.ToString() + " Infos complémentaire (TypeBoutique) :" + typeBoutique ;
            return result;

        }
        ///Methodes
        ///
    }
}
