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

namespace NyamRecipe.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListParts.xaml
    /// </summary>
    public partial class ListParts : Page
    {
        public ListParts()
        {
            InitializeComponent();
            TbCounter.Text = App.DB.Ingredient.Count().ToString();
            DtGreedient.ItemsSource = App.DB.Ingredient.ToList();
        }

        private void LinkEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LinkDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnFirstPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPreviousPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnNextPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLastPage_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
