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
    /// Logique d'interaction pour Ajout_personnel.xaml
    /// </summary>
    public partial class Ajout_personnel : UserControl
    {
        public Ajout_personnel()
        {
            InitializeComponent();
        }
        private void button_sorcier_Click(object sender, RoutedEventArgs e)
        {
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(typeof(Sorcier)))
            {              
                StackPanel stackPanel = new StackPanel();
                stackPanel.Orientation = Orientation.Vertical;
                stackPanel.Background = Brushes.White; 

                TextBlock textBlock = new TextBlock();
                textBlock.Text = descriptor.Name +"  ";
                stackPanel.Children.Add(textBlock);

                TextBox textBox = new TextBox();
                stackPanel.Children.Add(textBox);
                ajout.Children.Add(stackPanel);
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
       
    }
}
