using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.IO;
using System.ComponentModel;
using System.Reflection;
using System.Xml.Serialization;

namespace GestionParcInterface
{
    public static class Globals
    {
        static Parc zombilenium = new Parc(null, null, null, 0);

        internal static Parc Zombilenium { get => zombilenium; set => zombilenium = value; }
    }

    /// <summary>
    /// Logique d'interaction pour personnels.xaml
    /// </summary>
    public partial class personnels : UserControl
    {
        public personnels()
        {
            InitializeComponent();
        }

        private void button_ajout_employe_Click(object sender, RoutedEventArgs e)
        {
            Ajout_personnel ajout_Personnel = new Ajout_personnel();
            control.Children.Clear();
            control.Children.Add(ajout_Personnel);
        }

        private void button_affichage_personnels_Click(object sender, RoutedEventArgs e)
        {
            AffichagePersonnel affichagePersonnel = new AffichagePersonnel();
            control.Children.Clear();
            control.Children.Add(affichagePersonnel);
        }
    }
}
