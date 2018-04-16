using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInterface
{ 
    class Sorcier : Employe
    {
        ///Attributs
        ///

        Grade tatouage;
        List<string> pouvoirs;

        ///Constructeur
        ///
        public Sorcier()
        {
            this.Pouvoirs = new List<string>();
        }
        public Sorcier(Grade tatouage, List<string> pouvoirs, int matricule, string nom, string prenom, Sexe sexe, string fonctionDansEntreprise, List<string> pouvoir) 
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Sexe = sexe;
            this.FonctionDansEntreprise = fonctionDansEntreprise;
            this.Matricule = matricule;

            this.Tatouage = tatouage;
            this.Pouvoirs = pouvoir;
        }

        ///Accesseurs
        ///
        public Grade Tatouage { get => tatouage; set => tatouage = value; }

        //TODO: trouver une solution pour despliter
        public List<string> Pouvoirs { get => pouvoirs; set => pouvoirs = value; }

        public String PouvoirString
        {
            get
            {
                return this.pouvoirToString();
            }
        }


        private String pouvoirToString()
        {

            String result = "";
            foreach(String s in this.pouvoirs)
            {
                result += s + " ";
            }
            return result;

        }



        public override string ToString()
        {
            string result = "";
            result = base.ToString() + " Il possède un tatouage de Grade"+tatouage;
            return result;
        }

        ///Methodes
        ///
        public void ChangerTatouage( Grade tatouage )
        {
            this.Tatouage = tatouage;
        }

        public void AjouterPouvoir( string pouvoir )
        {
            if (!this.Pouvoirs.Contains(pouvoir)) this.Pouvoirs.Add(pouvoir);
            else Console.WriteLine("Pouvoir deja existant");
        }

        public void SupprimerPouvoir(string pouvoir)
        {
            if (!this.Pouvoirs.Contains(pouvoir)) this.Pouvoirs.Remove(pouvoir);
        }

        public void AfficherPouvoir()
        {
            Console.Write("\n|");
            foreach ( string p in Pouvoirs )
            {
                Console.Write(p.ToString() + "|");
            }
        }
    }
}
