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
            //InitializeComponent();
            gridd = new Grid();
            gridd.ShowGridLines = true;

            for (int i = 0; i < typeof(Parc).GetProperties().Length; i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                gridd.ColumnDefinitions.Add(col);
            }

            RowDefinition rowDef1 = new RowDefinition();
            gridd.RowDefinitions.Add(rowDef1);

            TextBlock txt1 = new TextBlock();
            txt1.Text = "2005 Products Shipped";
            txt1.FontSize = 20;
            txt1.FontWeight = FontWeights.Bold;
            Grid.SetColumnSpan(txt1, 3);
            Grid.SetRow(txt1, 0);

            gridd.Children.Add(txt1);
            
        }

        private void button_attractions_Click(object sender, RoutedEventArgs e)
        {

        }

        private void attractions_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
