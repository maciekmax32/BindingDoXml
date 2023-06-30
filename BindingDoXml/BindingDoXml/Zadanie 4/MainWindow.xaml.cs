using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Xml.Serialization;
using Zadanie_4;

namespace Zadanie_4
{
    public partial class MainWindow : Window
    {
        private List<Category> categories;

        public MainWindow()
        {
            InitializeComponent();
            LoadCategoriesFromXml();
            categoriesListBox.ItemsSource = categories;
        }

        private void LoadCategoriesFromXml()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Categories));
                using (FileStream fileStream = new FileStream("categories.xml", FileMode.Open))
                {
                    Categories categoriesData = (Categories)serializer.Deserialize(fileStream);
                    categories = categoriesData.CategoryList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas wczytywania danych z pliku XML: " + ex.Message);
            }   
        }

        private void ShowCategoryDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            Category selectedCategory = categoriesListBox.SelectedItem as Category;
            if (selectedCategory != null)
            {
                CategoryDetailsWindow detailsWindow = new CategoryDetailsWindow(selectedCategory);
                detailsWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wybierz kategorię, aby zobaczyć szczegóły.");
            }
        }
    }
}
    