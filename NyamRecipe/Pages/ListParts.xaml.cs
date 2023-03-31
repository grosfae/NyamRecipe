using NyamRecipe.Components.Model;
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
            Update();
            LblPages.Content = numberLb;
        }
        int numberLb = 1;
        int numberPage = 0;
        int count = 5;

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
            numberPage--;
            if (numberPage < 0)
                numberPage = 0;
            Update();
            if (numberPage != 0)
            {
                LblPages.Content = numberLb - 1;
            }
        }

        private void BtnNextPage_Click(object sender, RoutedEventArgs e)
        {
            numberPage++;
            if (DtGreedient.Items.Count < 5)
                numberPage--;
            Update();
            if (numberPage < 4)
            {
                LblPages.Content = numberLb + 1;
            }
        }

        private void BtnLastPage_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Update()
        {
            IEnumerable<Ingredient> partsList = App.DB.Ingredient;
            partsList = partsList.Skip(count * numberPage).Take(count);
            DtGreedient.ItemsSource = partsList;
        }
    }
}
