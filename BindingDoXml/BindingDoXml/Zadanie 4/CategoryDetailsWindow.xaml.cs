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
using System.Windows.Shapes;

namespace Zadanie_4
{
    /// <summary>
    /// Interaction logic for CategoryDetailsWindow.xaml
    /// </summary>
    public partial class CategoryDetailsWindow : Window
    {
        private Category category;

        public CategoryDetailsWindow(Category category)
        {
            InitializeComponent();
            this.category = category;
            detailsListBox.ItemsSource = category.Subcategories;
        }

        private void ShowSubcategoryDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            Subcategory selectedSubcategory = detailsListBox.SelectedItem as Subcategory;
            if (selectedSubcategory != null)
            {
                SubcategoryDetailsWindow detailsWindow = new SubcategoryDetailsWindow(selectedSubcategory);
                detailsWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wybierz podkategorię, aby zobaczyć szczegóły.");
            }
        }
    }
}