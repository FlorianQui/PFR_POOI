using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
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
    /// Logique d'interaction pour AffichagePersonnel.xaml
    /// </summary>
    public partial class AffichagePersonnel : UserControl
    {
        private Type type;
        public AffichagePersonnel()
        {
            InitializeComponent();
        }
        private void button_sorcier_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Sorcier> sorciers = new ObservableCollection<Sorcier>(Globals.Zombilenium.Personnel.Employes.OfType<Sorcier>().ToList());
            
            liste.ItemsSource = sorciers;
            button_recherche_classe.Text = " Sorcier";
            type = typeof(Sorcier);

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(typeof(Sorcier)))
            {
                TextBlock textBlock = new TextBlock();
                textBlock.Text = descriptor.Name;
                combobox_research.Items.Add(textBlock);
            }
        }

        private void button_monstres_Click(object sender, RoutedEventArgs e)
        {
            liste.ItemsSource = Globals.Zombilenium.Personnel.Employes.OfType<Monstre>().ToList();
            button_recherche_classe.Text = " Monstres";

            type = typeof(Monstre);

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(typeof(Monstre)))
            {
                TextBlock textBlock = new TextBlock();
                textBlock.Text = descriptor.Name;
                combobox_research.Items.Add(textBlock);
            }
        }

        private void button_demons_Click(object sender, RoutedEventArgs e)
        {
            liste.ItemsSource = Globals.Zombilenium.Personnel.Employes.OfType<Demon>().ToList();
            button_recherche_classe.Text = " Démons";

            type = typeof(Demon);

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(typeof(Demon)))
            {
                TextBlock textBlock = new TextBlock();
                textBlock.Text = descriptor.Name;
                combobox_research.Items.Add(textBlock);
            }
        }

        private void button_zombies_Click(object sender, RoutedEventArgs e)
        {
            liste.ItemsSource = Globals.Zombilenium.Personnel.Employes.OfType<Zombie>().ToList();
            button_recherche_classe.Text = " Zombie";

            type = typeof(Zombie);

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(typeof(Zombie)))
            {
                TextBlock textBlock = new TextBlock();
                textBlock.Text = descriptor.Name;
                combobox_research.Items.Add(textBlock);
            }
        }

        private void button_loup_garou_Click(object sender, RoutedEventArgs e)
        {
            liste.ItemsSource = Globals.Zombilenium.Personnel.Employes.OfType<LoupGarou>().ToList();
            button_recherche_classe.Text = " Loug-Garou";

            type = typeof(LoupGarou);

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(typeof(LoupGarou)))
            {
                TextBlock textBlock = new TextBlock();
                textBlock.Text = descriptor.Name;
                combobox_research.Items.Add(textBlock);
            }

        }

        private void button_fantomes_Click(object sender, RoutedEventArgs e)
        {
            liste.ItemsSource = Globals.Zombilenium.Personnel.Employes.OfType<Fantome>().ToList();
            button_recherche_classe.Text = " Fantôme";

            type = typeof(Fantome);

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(typeof(Fantome)))
            {
                TextBlock textBlock = new TextBlock();
                textBlock.Text = descriptor.Name;
                combobox_research.Items.Add(textBlock);
            }
        }

        private void liste_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Debug.WriteLine(sender.GetType());
            
        }

        private void result_research_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_research_Click(object sender, RoutedEventArgs e)
        {
            //combobox_research.SelectionBoxItemStringFormat

            //var result = Globals.Zombilenium.Personnel.Employes.FindAll(e =>
            //{
            //    type.GetProperty(textbox_select_research.Text);
                
            //});
        }

        private void liste_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if(type == typeof(Sorcier))
            {
                Sorcier sorcier = e.Row.DataContext as Sorcier;
                Globals.Zombilenium.Personnel.Employes.Add(sorcier);
                MessageBox.Show("ajouter cet employe");
            }
            if (type == typeof(Monstre))
            {
                Monstre sorcier = e.Row.DataContext as Monstre;
                Globals.Zombilenium.Personnel.Employes.Add(sorcier);
                MessageBox.Show("ajouter cet employe");
            }
            if (type == typeof(Demon))
            {
                Demon sorcier = e.Row.DataContext as Demon;
                Globals.Zombilenium.Personnel.Employes.Add(sorcier);
                MessageBox.Show("ajouter cet employe");
            }
            if (type == typeof(Fantome))
            {
                Fantome sorcier = e.Row.DataContext as Fantome;
                Globals.Zombilenium.Personnel.Employes.Add(sorcier);
                MessageBox.Show("ajouter cet employe");
            }
            if (type == typeof(Zombie))
            {
                Zombie sorcier = e.Row.DataContext as Zombie;
                Globals.Zombilenium.Personnel.Employes.Add(sorcier);
                MessageBox.Show("ajouter cet employe");
            }
            if (type == typeof(LoupGarou))
            {
                LoupGarou sorcier = e.Row.DataContext as LoupGarou;
                Globals.Zombilenium.Personnel.Employes.Add(sorcier);
                MessageBox.Show("ajouter cet employe");
            }

        }
    }
}
