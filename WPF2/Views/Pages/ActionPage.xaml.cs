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
    /// Логика взаимодействия для ActionPage.xaml
    /// </summary>
    public partial class ActionPage : Page

    {
        public Book Book { get; set; }
        public List<Author> Authors { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Publisher> Publishers { get; set; }


        public ActionPage(Book book)
        {
            InitializeComponent();
            this.Book = book;
            Authors = AppData.db.Author.ToList();
            Genres = AppData.db.Genre.ToList();
            Publishers = AppData.db.Publisher.ToList();
            this.DataContext = this;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (Book.ID == 0)
            {
                AppData.db.Book.Add(Book);
            }
            AppData.db.SaveChanges();
            MessageBox.Show("Данные сохранены!","Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.GoBack();
             
        }
    }
}
