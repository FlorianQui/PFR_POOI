using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Zombi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello Zombi");
            Console.ReadKey();
            Parc parc = new Parc("Hello", "18 r", "peur", 20000);

            Employe e = new Employe("robic", "gaetan", "34", Sexe.Feminin, "noob", 1, 8729918);
            Employe b = new Employe("zzoo", "GGGGGGGG", "34", Sexe.Feminin, "noob", 1, 8729918);

            Sorcier s = new Sorcier();

            parc.AjouterEmployeDuPersonnel(e);
            parc.AjouterEmployeDuPersonnel(b);

            parc.Personnel.AfficherListePersonnel();

            Console.ReadKey();

            parc.LicencierEmployeDuPersonnel(e);
            parc.Personnel.AfficherListePersonnel();

            Console.ReadKey();
        }
    }
}
