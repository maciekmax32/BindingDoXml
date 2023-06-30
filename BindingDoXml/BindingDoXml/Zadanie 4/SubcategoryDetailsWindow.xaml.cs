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
    public partial class SubcategoryDetailsWindow : Window
    {
        public SubcategoryDetailsWindow(Subcategory subcategory)
        {
            InitializeComponent();
            detailsDataGrid.ItemsSource = subcategory.Details;
        }
    }
}
