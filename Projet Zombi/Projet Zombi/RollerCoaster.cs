using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class RollerCoaster : Attraction
    {
        ///Attributs
        ///
        int ageMini;
        float tailleMini;
        TypeCategorie typeCategorie;

        ///Constructeurs
        ///
        public RollerCoaster()
        {
                
        }
        public RollerCoaster(string nom, string typeDeBesoin, int identifiant, int nbMonstreMini, int ageMini, float tailleMini, TypeCategorie typeCategorie )
        {
            this.Nom = nom;
            this.TypeDeBesoin = typeDeBesoin;
            this.Identifiant = identifiant;
            this.NbMonstreMini = nbMonstreMini;

            this.Equipe = new List<Monstre>();
            this.EnService = false;

            this.AgeMini = ageMini;
            this.TailleMini = tailleMini;
            this.TypeCategorie = typeCategorie;
        }

        ///Accesseurs
        ///
        public int AgeMini { get => ageMini; set => ageMini = value; }
        public float TailleMini { get => tailleMini; set => tailleMini = value; }
        public TypeCategorie TypeCategorie { get => typeCategorie; set => typeCategorie = value; }

        ///Methodes
        ///
        public override string ToString()
        {
            string result = "";
            result = base.ToString() + " Les prérequis mini sont : "+ageMini+ "ans "+ tailleMini+ " m. Info complémentaire (TypeCatégorie) "+TypeCategorie;
            return result;

        }
    }
}
