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

namespace lab_122_wpf_code_first_database_02
{
    /// <summary>
    /// Interaction logic for UpdateTab.xaml
    /// </summary>
   public partial class UpdateTab : Window
    {
        public UpdateTab()
        {
            InitializeComponent();
            //var testWindow = new MainWindow();
            //testWindow.Initialise();
            Initialise();
        }

        public void Initialise()
        {
            cAuthor.SelectionChanged -= CAuthor_SelectionChanged;
            List<Author> authors = new List<Author>();
            using (var db = new BookShelfContext())
            {
                authors = db.Authors.ToList<Author>();
            }
            cAuthor.ItemsSource = authors;
            cAuthor.DisplayMemberPath = "AuthorName";
            cAuthor.SelectionChanged += CAuthor_SelectionChanged;
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new BookShelfContext())
            {
                var a = new List<Author>();
                a.Add(cAuthor.SelectedItem as Author);
                var book1 = new Book
                {
                    BookName = tBookName.Text,
                    BookGenre = Textbox02.Text,
                    Quantity = Convert.ToInt32(Textbox03.Text),
                    Authors = a
                };
                db.Books.Add(book1);
                db.SaveChanges();
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            var HomeWindow = new MainWindow();
            HomeWindow.Show();
            this.Close();
        }

        private void CAuthor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
