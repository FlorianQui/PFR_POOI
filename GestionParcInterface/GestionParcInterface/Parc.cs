using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Reflection;
using System.Xml.Serialization;
using System.Diagnostics;

namespace GestionParcInterface
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
                monstre.Affectation = ListeAttraction.Find(attraction => attraction.Nom == "Barbe Noire");
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

        public void AfficherListe<T>(List<T> liste)
        {
            foreach (T t in liste)
            {
                Console.WriteLine(t.ToString());
            }
        }
        public List<T> ListeParClasse<T>(List<T> liste, string classe)
        {
            Type type = Type.GetType("GestionParcInterface." + classe);

            if (type != null)
            {
                List<T> result = new List<T>();
                foreach (T t in liste.FindAll(t => t.GetType() == type))
                    result.Add(t); //TODO

                return result;
            }
            else return null;
        }

        public void TrierParCritere<T>(List<T> liste, string critere, OrdreTrie ordreTrie) where T : IComparable
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


        public List<T> TrierParClasseEtCritere<T>(List<T> liste, string classe, string critere, OrdreTrie ordre) where T : IComparable
        {
            List<T> result = ListeParClasse(liste, classe);
            TrierParCritere(result, critere, ordre);

            return result;
        }

        public List<T> Query<T> (List<T> liste, string critere, dynamic value ) 
        {
            var query = from T t in liste
                        where typeof(T).GetProperty(critere).GetValue(t).Equals(value)
                        select t;
            return query.ToList();
        }

        public void EcrireListeVersCSV<T>(List<T> liste)
        {
            Console.WriteLine("Starting write to csv ...");
            using (StreamWriter writer = new StreamWriter(typeof(T).Name + ".csv"))
            { 
                foreach (T t in liste)
                {
                    writer.Write(t.GetType().Name + ";");
                    foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(t.GetType()))
                    {
                        writer.Write(descriptor.GetValue(t) + ";");
                    }
                    writer.WriteLine();
                }
            }
        }
        public void PeuplementCSV()
        {
            Debug.WriteLine("Starting peuplement via csv");
            try
            {
                StreamReader reader = new StreamReader("C:/Users/flori/Documents/GitHub/PFR_POOI/GestionParcInterface/GestionParcInterface/bin/Debug/Listing.csv");
                
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(';');
                    Peuplement(line);
                }
            }
            catch (Exception err)
            {
                //err = new FileNotFoundException();
                Debug.WriteLine(err.Message);
            }
        }

        public void Peuplement(string[] line)
        {
            try
            {
                Type type = Type.GetType("GestionParcInterface." + line[0]);
                Debug.WriteLine(type);
                if (type != null)
                {
                    
                    try
                    {
                        dynamic obj = Activator.CreateInstance(type);
                        
                        if (obj is Attraction)
                        {
                            
                            obj.Identifiant = int.Parse(line[1]);
                            obj.Nom = line[2];
                            obj.NbMonstreMini = int.Parse(line[3]);
                            obj.BesoinSpecifique = bool.Parse(line[4]);
                            obj.TypeBesoin = line[5];

                            if (obj is Boutique) if (line[6] != null) obj.TypeBoutique = ChoixTypeBoutique(line[6]);
                            if (obj is DarkRide) obj.Vehicule = bool.Parse(line[7]); //TODO duree timespan
                            if (obj is RollerCoaster) if (line[6] != null)
                                {
                                    obj.TypeCategorie = ChoixTypeCategorie(line[6]);
                                    obj.AgeMini = int.Parse(line[7]);
                                    obj.TailleMini = float.Parse(line[8]);
                                }
                            if (obj is Spectacle)
                            {
                                obj.NbPlaces = int.Parse(line[7]);
                                obj.Salle = new Salle(line[6], obj.NbPlaces);
                                //TODO horaire reservation
                            }

                            AjoutAttraction(obj);
                        }
                        else
                        {
                            obj.Matricule = int.Parse(line[1]);
                            obj.Nom = line[2];
                            obj.Prenom = line[3];
                            if (line[4] != null) obj.Sexe = ChoixSexe(line[4]);
                            obj.FonctionDansEntreprise = line[5];

                            if (!(obj is Sorcier))
                            {
                                obj.Cagnotte = int.Parse(line[6]);
                                // if (line[7] != null) obj.Affectation = this.ListeAttraction.Find(attraction => attraction.Identifiant == int.Parse(line[7]));
                                
                                if (obj is Demon) obj.Force = int.Parse(line[8]);
                                if (obj is LoupGarou) obj.IndiceCruaute = double.Parse(line[8]);
                                if (obj is Vampire) obj.IndiceLuminosite = double.Parse(line[8]);
                                if (obj is Zombie)
                                {
                                    obj.DegreDecomposition = int.Parse(line[9]);
                                    if (line[8] != null) obj.CouleurZombie = ChoixCouleurZombie(line[8]);
                                }
                            }

                            if (obj is Sorcier)
                            {
                                if (line[7] != null)
                                {
                                    string[] pouvoir = line[7].Split('-');
                                    foreach (string s in pouvoir) obj.Pouvoirs.Add(s);
                                }

                            }
                            Debug.WriteLine("ajout");
                            AjouterEmployeDuPersonnel(obj);
                        }
                    }
                    catch (MissingMethodException err)
                    {
                        err = new MissingMethodException();
                        Debug.WriteLine(err.Message + " Type " + type.Name);
                    }
                }
            }
            catch (NullReferenceException)
            {
                Debug.WriteLine("Classe invalide");
            }
        }

        public Sexe ChoixSexe(string line)
        {
            line.ToLower();
            return line == "male" ? Sexe.male : line == "femelle" ? Sexe.femelle : Sexe.autre;
        }
        public CouleurZombie ChoixCouleurZombie(string line)
        {
            line.ToLower();
            return line == "bleuatre" ? CouleurZombie.bleuatre : CouleurZombie.grisatre;
        }
        public TypeBoutique ChoixTypeBoutique(string line)
        {
            line.ToLower();
            return line == "barbreapapa" ? TypeBoutique.barbeAPapa : line == "nourriture" ? TypeBoutique.nourriture : TypeBoutique.souvenir;
        }
        public TypeCategorie ChoixTypeCategorie(string line)
        {
            line.ToLower();
            return line == "assise" ? TypeCategorie.assise : line == "bobsleigh" ? TypeCategorie.bobsleigh : TypeCategorie.inverse;
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
