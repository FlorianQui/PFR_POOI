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

         

            parc.Personnel.RecruterEmployePersonnel(e);

            parc.Personnel.AfficherListePersonnel();


            Console.ReadKey();
        }
    }
}
