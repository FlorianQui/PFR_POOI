﻿using System;
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
            ok.Content = "hh";
            dk.Background = Brushes.Black;
        }
    }
}