using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Reflection;

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
                monstre.Affectation = ListeAttraction.Find(attraction => attraction.Nom == "BarbeAPapa");
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

        //TODO remplacer la personne qui est affectée a la barbe a papa qd il y a pas assez de personne ds l'attraction



        public void TrierParClasseEtCritere<T>(List<T> liste, string critere, OrdreTrie ordreTrie) where T : IComparable
        {
            try
            {
                var prop = typeof(T).GetProperty(critere);

                if (prop != null)
                {
                    Comparison<T> asc = (T t1, T t2) => ((IComparable)prop.GetValue(t1)).CompareTo(prop.GetValue(t2));
                    Comparison<T> desc = (T t1, T t2) => ((IComparable)prop.GetValue(t2)).CompareTo(prop.GetValue(t1));

                    liste.Sort(ordreTrie == OrdreTrie.ASC ? asc : desc);
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Propriete invalide");
            }
        }

        public void EcrireListeVersCSV<T>(List<T> liste)
        {
            using (StreamWriter writer = new StreamWriter("[" + typeof(T).Name + "]" + ".txt"))
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(typeof(T)))
                    writer.Write(descriptor.Name + ";");

                writer.WriteLine();

                foreach (T t in liste)
                {
                    foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(typeof(T)))
                    {
                        writer.Write(descriptor.GetValue(t) + ";");
                    }
                    writer.WriteLine();
                }
            }
        }
        public void PeuplementCSV()
        {
            try
            {
                StreamReader reader = new StreamReader("Feuil1.csv");

                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(';');

                    Peuplement(line);
                }
            }
            catch (FileNotFoundException err)
            {
                err = new FileNotFoundException();
                Console.WriteLine(err.Message);
            }
        }

        public void Peuplement(string[] line)
        {
            try
            {
                Type type = Type.GetType("Projet_Zombi." + line[0]);

                if (type != null)
                {
                    object obj = Activator.CreateInstance(type, new object[] { "nom", null, null, null, null, null, null });

                    this.Personnel.Employes.Add(obj as ty);
                }

                
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Classe invalide");
            }
        }

        public static I CreateInstance<I>() where I : class
        {
            string assemblyPath = Environment.CurrentDirectory + "\\DynamicCreateInstanceofclass.exe";

            Assembly assembly;

            assembly = Assembly.LoadFrom(assemblyPath);
            Type type = assembly.GetType("DynamicCreateInstanceofclass.UserDetails");
            return Activator.CreateInstance(type) as I;
        }

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
