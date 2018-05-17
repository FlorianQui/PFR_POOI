using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour Ajout_personnel.xaml
    /// </summary>
    public partial class Ajout_personnel : UserControl
    {
        private Type type;
        public Ajout_personnel()
        {
            InitializeComponent();
        }
        private void button_sorcier_Click(object sender, RoutedEventArgs e)
        {
            type = typeof(Sorcier);
            int i = 0;
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(typeof(Sorcier)))
            {              
                StackPanel stackPanel = new StackPanel();
                stackPanel.Orientation = Orientation.Vertical;
                stackPanel.Background = Brushes.White; 

                TextBox textBlock = new TextBox();
                textBlock.Text = descriptor.Name;
                stackPanel.Children.Add(textBlock);

                TextBox textBox = new TextBox();
                stackPanel.Children.Add(textBox);

                ajout.Children.Add(stackPanel);
                i++;
            }
            Button validation = new Button();
            ajout.Children.Add(validation);
            //ajout.header
        }
        private void button_monstres_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void button_demons_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_zombies_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_loup_garou_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void button_fantomes_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button_test_Click(object sender, RoutedEventArgs e)
        {
            List<string> employe = new List<string>();
            foreach (StackPanel v in ajout.Children)
            {
                var t = v.Children[1] as TextBox;
                employe.Add(t.Text);
            }
            dynamic obj = Activator.CreateInstance(type);
            obj.Matricule = int.Parse(employe[7]);
            obj.Nom = employe[3];
            obj.Prenom = employe[4];
            if (employe[4] != null) obj.Sexe = Globals.Zombilenium.ChoixSexe(employe[5]);
            obj.FonctionDansEntreprise = employe[6];

            if (!(obj is Sorcier))
            {
                obj.Cagnotte = int.Parse(employe[6]); // .
                // if (line[7] != null) obj.Affectation = this.ListeAttraction.Find(attraction => attraction.Identifiant == int.Parse(line[7]));

                if (obj is Demon) obj.Force = int.Parse(employe[8]); //.
                if (obj is LoupGarou) obj.IndiceCruaute = double.Parse(employe[8]);//.
                if (obj is Vampire) obj.IndiceLuminosite = double.Parse(employe[8]);//.
                if (obj is Zombie)//.
                {
                    obj.DegreDecomposition = int.Parse(employe[9]);
                    if (employe[8] != null) obj.CouleurZombie = Globals.Zombilenium.ChoixCouleurZombie(employe[8]);
                }
            }

            if (obj is Sorcier)
            {
                obj.Tatouage = employe[0];
                if (employe[1] != null)

                {
                    string[] pouvoir = employe[1].Split('-');
                    foreach (string s in pouvoir) obj.Pouvoirs.Add(s);
                }

            }
           
        }
    }
}
