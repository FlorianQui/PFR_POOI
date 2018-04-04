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

        Grade tatouage;
        List<Pouvoir> pouvoirs;

        ///Constructeur
        ///
        public Sorcier(string nom, string prenom, Sexe sexe, string fonctionDansEntreprise, int matricule, Grade tatouage, List<Pouvoir> pouvoirs) 
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Sexe = sexe;
            this.FonctionDansEntreprise = fonctionDansEntreprise;
            this.Matricule = matricule;

            this.Tatouage = tatouage;
            this.Pouvoirs = pouvoirs;
        }

        ///Accesseurs
        ///
        public Grade Tatouage { get => tatouage; set => tatouage = value; }
        public List<Pouvoir> Pouvoirs { get => pouvoirs; set => pouvoirs = value; }

        ///Methodes
        ///
        public void ChangerTatouage( Grade tatouage )
        {
            this.Tatouage = tatouage;
        }

        public void AjouterPouvoir( Pouvoir pouvoir )
        {
            if (!this.Pouvoirs.Contains(pouvoir)) this.Pouvoirs.Add(pouvoir);
            else Console.WriteLine("Pouvoir deja existant");
        }

        public void SupprimerPouvoir(Pouvoir pouvoir)
        {
            if (!this.Pouvoirs.Contains(pouvoir)) this.Pouvoirs.Remove(pouvoir);
        }

        public void AfficherPouvoir()
        {
            Console.Write("\n|");
            foreach ( Pouvoir p in Pouvoirs )
            {
                Console.Write(p.ToString() + "|");
            }
        }
    }
}
