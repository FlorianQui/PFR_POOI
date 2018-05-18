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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Globals.Zombilenium.PeuplementCSV();
        }

        private void button_personnel_Click(object sender, RoutedEventArgs e)
        {
            personnels personnels = new personnels();

            control.Children.Clear();
            control.Children.Add(personnels);
        }

        private void button_home_Click(object sender, RoutedEventArgs e)
        {
            parc parc = new parc();
            control.Children.Clear();
            control.Children.Add(parc);
        }

        private void button_attractions_Click(object sender, RoutedEventArgs e)
        {
            attractions attractions = new attractions();
            control.Children.Clear();
            control.Children.Add(attractions);
        }
    }
}
