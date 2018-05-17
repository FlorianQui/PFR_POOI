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

namespace GestionParcInterface
{
    /// <summary>
    /// Logique d'interaction pour attractions.xaml
    /// </summary>
    public partial class attractions : UserControl
    {
        public attractions()
        {
            InitializeComponent();
        }

        private void click_attractions(object sender, RoutedEventArgs e)
        {
            
         //   liste.ItemsSource = Globals.Zombilenium.Personnel.Employes.OfType<Sorcier>().ToList();
        }

        private void button_boutique_Click(object sender, RoutedEventArgs e)
        {
            liste.ItemsSource = Globals.Zombilenium.ListeAttraction.OfType<Boutique>().ToList();
        }

        private void button_darkride_Click(object sender, RoutedEventArgs e)
        {
            liste.ItemsSource = Globals.Zombilenium.ListeAttraction.OfType<DarkRide>().ToList();
        }

        private void button_rollercoaster_Click(object sender, RoutedEventArgs e)
        {

            liste.ItemsSource = Globals.Zombilenium.ListeAttraction.OfType<RollerCoaster>().ToList();
        }

        private void button_spectable_Click(object sender, RoutedEventArgs e)
        {

            liste.ItemsSource = Globals.Zombilenium.ListeAttraction.OfType<Spectacle>().ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
