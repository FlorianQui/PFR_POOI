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
        private int[] arg;
        public Ajout_personnel()
        {
            InitializeComponent();
        }
        private void button_sorcier_Click(object sender, RoutedEventArgs e)
        {
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
<<<<<<< HEAD
            Button validation = new Button();
            ajout.Children.Add(validation);
            //ajout.header
            
=======
>>>>>>> 2e16d4c6e2371e851180919de3fe51882e29e14f
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
        }
    }
}
