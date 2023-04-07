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
using NyamRecipe.Components.Model;

namespace NyamRecipe.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditPart.xaml
    /// </summary>
    public partial class AddEditPart : Page
    {
        Ingredient contextIngridient;
        public AddEditPart(Ingredient ingredient)
        {
            InitializeComponent();
            contextIngridient = ingredient;
            DataContext = contextIngridient;
        }
    }
}
