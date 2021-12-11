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
using WPF2.Context;
using WPF2.Model;

namespace WPF2.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataSource.ItemsSource = AppData.db.Book.ToList();
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ActionPage(new Model.Book()));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var editBook = (Book)DataSource.SelectedItem;
            if(editBook != null)
            {
                NavigationService.Navigate(new ActionPage(editBook));
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var deleteBook = (Book)DataSource.SelectedItem;
            if (deleteBook != null)
            {
                AppData.db.Book.Remove(deleteBook);
                AppData.db.SaveChanges();
                MessageBox.Show("Данные удалены!", "Удаление", MessageBoxButton.OK, MessageBoxImage.Information);
                Page_Loaded(null, null);
            }
        }
    }
}
