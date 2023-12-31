﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using WinForms = System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//TO DO:  Send file path to backend, ensure user uploads a manifest before proceeding
namespace Integrative_Systems_Solution
{
    public partial class Upload_Manifest : Page
    {
        public Upload_Manifest()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //pass manifest path to backend

            //Check which operation were doing before moving to the next page
            
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;

            //balance
            if(mainwindow.GlobalVariable.Text == "B")
            {
                mainwindow.mainFrame.Navigate(new X_moves_in_X_minutes());
            }
            

            //load
            if(mainwindow.GlobalVariable.Text == "LUL")
            {
                mainwindow.mainFrame.Navigate(new Unload_Select());
            }
            
        }

        private void FileSelect_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;

            WinForms.OpenFileDialog dialog = new WinForms.OpenFileDialog();
            dialog.Filter = "Text Files | *.txt";
            WinForms.DialogResult result = dialog.ShowDialog();

            if(result == WinForms.DialogResult.OK)
            {
                string filepath = dialog.FileName;
                //give this path to backend
                string filename = RemoveFileExtension(dialog.SafeFileName);

                mainwindow.ManifestNameDisplay.Text = filename;
            }

        }

        private string RemoveFileExtension(string name)
        {
            // Find the position of the last dot (if any)
            int lastDotIndex = name.LastIndexOf('.');

            // If there is a dot, extract the substring before it
            if (lastDotIndex != -1)
            {
                return name.Substring(0, lastDotIndex);
            }

            // If no dot is found, return the original string
            return name;
        }
    }
}
