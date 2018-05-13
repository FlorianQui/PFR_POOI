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

        private void button_sorcier_Click(object sender, RoutedEventArgs e)
        {
            liste.ItemsSource = Globals.Zombilenium.Personnel.Employes.OfType<Sorcier>().ToList();
        }

        private void button_monstres_Click(object sender, RoutedEventArgs e)
        {
            liste.ItemsSource = Globals.Zombilenium.Personnel.Employes.OfType<Monstre>().ToList();
        }

        private void button_demons_Click(object sender, RoutedEventArgs e)
        {
            liste.ItemsSource = Globals.Zombilenium.Personnel.Employes.OfType<Demon>().ToList();
        }

        private void button_zombies_Click(object sender, RoutedEventArgs e)
        {
            liste.ItemsSource = Globals.Zombilenium.Personnel.Employes.OfType<Zombie>().ToList();
        }

        private void button_loup_garou_Click(object sender, RoutedEventArgs e)
        {
            liste.ItemsSource = Globals.Zombilenium.Personnel.Employes.OfType<LoupGarou>().ToList();
        }

        private void button_fantomes_Click(object sender, RoutedEventArgs e)
        {
            liste.ItemsSource = Globals.Zombilenium.Personnel.Employes.OfType<Fantome>().ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void liste_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Debug.WriteLine(sender.GetType());
        }
    }
}
