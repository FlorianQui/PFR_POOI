﻿using System;
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
        private String nom, addresse, themeParc;
        private int capital;
        private List<Employe> direction;
        private List<Attraction> listeAttraction;
        private Personnel personnel;

        ///Constructeur
        ///
        public Parc(string nom, string addresse, string themeParc, int capital)
        {
            this.Nom = nom;
            this.Addresse = addresse;
            this.ThemeParc = themeParc;
            this.Capital = capital;

            listeAttraction = new List<Attraction>();
            direction = new List<Employe>();
            personnel = new Personnel();
        }

        ///Accesseurs
        ///
        public string Nom { get => nom; set => nom = value; }
        public string Addresse { get => addresse; set => addresse = value; }
        public string ThemeParc { get => themeParc; set => themeParc = value; }
        public int Capital { get => capital; set => capital = value; }
        internal List<Employe> Direction { get => direction; set => direction = value; }
        internal List<Attraction> ListeAttraction { get => listeAttraction; set => listeAttraction = value; }
        internal Personnel Personnel { get => personnel; set => personnel = value; }

        ///Méthodes
        ///
        public bool AjouterMembreDirection(Employe employe)
        {
            bool result = false;

            if (!Direction.Contains(employe))
            {
                Direction.Add(employe);
                result = true;
            }

            Direction.Sort((Employe e1, Employe e2) =>
            {
                return e1.Nom.CompareTo(e2.Nom);
            });

            return result;
        }

        public bool LicencierMembreDirection(Employe employe)
        {
            bool result = false;

            if (Direction.Contains(employe))
            {
                Direction.Remove(employe);
                result = true;
            }

            return result;
        }

        public bool AjouterEmployeDuPersonnel(Employe employe)
        {
            bool result = false;

            if (!Personnel.Employes.Contains(employe))
            {
                personnel.Employes.Add(employe);
                result = true;
            }

            personnel.Employes.Sort((Employe e1, Employe e2) =>
            {
                return e1.Nom.CompareTo(e2.Nom);
            });

            return result;
        }

        public bool LicencierEmployeDuPersonnel(Employe employe)
        {
            bool result = false;

            if (Personnel.Employes.Contains(employe))
            {
                personnel.Employes.Remove(employe);
                result = true;
            }

            return result;
        }
        public void ModifDeCagnotte(Monstre monstre)
        {
            if (monstre.Cagnotte < 50 && monstre.Affectation.Equipe.Count() > monstre.Affectation.NbMonstreMini)
            {           
                monstre.Affectation = null;
                monstre.Affectation = ListeAttraction.Find(x => x.Nom == "BarbeaPapa");
            }
            if (monstre.Cagnotte > 500 && (monstre is Demon || monstre is Zombie) && (monstre.Affectation.Equipe.Count() > monstre.Affectation.NbMonstreMini))
            {
                monstre.Affectation = null;
            }
        }
        public bool AjoutAttraction(Attraction attraction)
        {
            bool result = false;
            if (!ListeAttraction.Contains(attraction))
            {
                ListeAttraction.Add(attraction);
                result = true;
            }
            return result;
        }
        //TODO gaetan lire csv pour ajouter membres

        //TODO gaetan afficher membres direction et personnel

        //TODO florian evoluer personnel et attractions ( 2 methodes != ) !!!!!!!! a implementer dans chaque classes !!!!!!!!

        //TODO florian trier personnel et attractions en fonction critères
        //TODO remplacer la personne qui est affectée a la barbe a papa qd il y a pas assez de personne ds l'attraction
        ///ToString
        ///
        public override string ToString()
        {
            string result = "";
            result = "le Parc " + nom + " est situé a :" + addresse + " et a pour thème : " + themeParc + " et a pour capital " + capital + "€";
            return result;
        }
    }
}
