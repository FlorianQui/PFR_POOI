using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private Type type;
        public attractions()
        {
            InitializeComponent();
        }

        private void button_boutique_Click(object sender, RoutedEventArgs e)
        {
            liste.ItemsSource = Globals.Zombilenium.ListeAttraction.OfType<Boutique>().ToList();

            type = typeof(Boutique);

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(typeof(Monstre)))
            {
                TextBlock textBlock = new TextBlock();
                textBlock.Text = descriptor.Name;
                //combobox_research.Items.Add(textBlock);
            }
        }

        private void button_darkride_Click(object sender, RoutedEventArgs e)
        {
            liste.ItemsSource = Globals.Zombilenium.ListeAttraction.OfType<DarkRide>().ToList();
            type = typeof(DarkRide);
        }

        private void button_rollercoaster_Click(object sender, RoutedEventArgs e)
        {

            liste.ItemsSource = Globals.Zombilenium.ListeAttraction.OfType<RollerCoaster>().ToList();
            type = typeof(RollerCoaster);
        }

        private void button_spectable_Click(object sender, RoutedEventArgs e)
        {

            liste.ItemsSource = Globals.Zombilenium.ListeAttraction.OfType<Spectacle>().ToList();
            type = typeof(Spectacle);
        }

        private void liste_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (type == typeof(Boutique))
            {
                Boutique bouti = e.Row.DataContext as Boutique;
                Globals.Zombilenium.ListeAttraction.Add(bouti);
                MessageBox.Show("ajouter cette attraction");
            }
            if (type == typeof(DarkRide))
            {
                DarkRide bouti = e.Row.DataContext as DarkRide;
                Globals.Zombilenium.ListeAttraction.Add(bouti);
                MessageBox.Show("ajouter cette attraction");
            }
            if (type == typeof(RollerCoaster))
            {
                RollerCoaster bouti = e.Row.DataContext as RollerCoaster;
                Globals.Zombilenium.ListeAttraction.Add(bouti);
                MessageBox.Show("ajouter cette attraction");
            }
            if (type == typeof(Spectacle))
            {
                Spectacle bouti = e.Row.DataContext as Spectacle;
                Globals.Zombilenium.ListeAttraction.Add(bouti);
                MessageBox.Show("ajouter cette attraction");
            }

        }
    }
}
