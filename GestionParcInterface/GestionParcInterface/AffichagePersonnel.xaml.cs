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
    /// Logique d'interaction pour AffichagePersonnel.xaml
    /// </summary>
    public partial class AffichagePersonnel : UserControl
    {
        public AffichagePersonnel()
        {
            //InitializeComponent();
            GridAffichage = new Grid();
            GridAffichage.ShowGridLines = true;

            for (int i = 0; i < typeof(Parc).GetProperties().Length; i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                GridAffichage.ColumnDefinitions.Add(col);
            }

            RowDefinition rowDef1 = new RowDefinition();
            GridAffichage.RowDefinitions.Add(rowDef1);
        }

    }
}
