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
//TO DO: alot, implement ability to add mulitple containers and display to user, scroll bar for these displayed conatiners (maybe),
//check input for valid input, send all container to back end using a data structure (undecided which yet)
namespace Integrative_Systems_Solution
{
    /// <summary>
    /// Interaction logic for Load_Select.xaml
    /// </summary>
    public partial class Load_Select : Page
    {
        public Load_Select()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;
            mainwindow.mainFrame.Navigate(new Calculating());
        }
    }
}
