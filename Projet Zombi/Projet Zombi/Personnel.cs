using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class Personnel
    {
        ///Attributs
        ///

        private List<Employe> employes;
        private Employe responsableSyndical;

        ///Constructeur
        ///

        public Personnel()
        {
            employes = new List<Employe>();
        }

        ///Accesseurs
        ///

        internal List<Employe> Employes { get => employes; set => employes = value; }
        internal Employe ResponsableSyndical { get => responsableSyndical; set => responsableSyndical = value; }

        ///Méthodes
        ///

        public void AfficherListePersonnel()
        {
            foreach ( Employe e in Employes )
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
