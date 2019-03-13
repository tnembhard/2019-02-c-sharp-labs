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
using System.Data.Entity;

namespace lab_122_wpf_code_first_database_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        public void Initialise()
        {
            lBox1.SelectionChanged -= LBox1_SelectionChanged;
            List<Book> books = new List<Book>();
            using (var db = new BookShelfContext())
            {
                books = db.Books.ToList<Book>();
            }
            lBox1.ItemsSource = books;
            lBox1.DisplayMemberPath = "BookName";
            lBox1.SelectionChanged += LBox1_SelectionChanged;

            lBoxAuthor.SelectionChanged -= LBoxAuthor_SelectionChanged;
            List<Author> authors = new List<Author>();
            using (var db = new BookShelfContext())
            {
                authors = db.Authors.ToList<Author>();
            }
            lBoxAuthor.ItemsSource = authors;
            lBoxAuthor.DisplayMemberPath = "AuthorName";
            lBoxAuthor.SelectionChanged += LBoxAuthor_SelectionChanged;
        }

        private void BtnUpdateWin_Click(object sender, RoutedEventArgs e)
        {
            var UpdateWindow = new UpdateTab();
            UpdateWindow.Show();
            this.Close();
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            Initialise();
        }

        private void LBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Book book;
            book = (Book)lBox1.SelectedItem;
            //Author auth;
            //auth = book.Authors as Author;
            lBox2.Items.Clear();
            lBox2.Items.Add(book.BookName);
            lBox2.Items.Add(book.BookGenre);
            lBox2.Items.Add(book.Quantity);
            //lBox2.Items.Add(auth.AuthorName);
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new BookShelfContext())
            {
                lBox1.SelectionChanged -= LBox1_SelectionChanged;
                Book b = new Book();
                b = lBox1.SelectedItem as Book;
                db.Books.Remove(db.Books.Where(book => book.BookId == b.BookId).FirstOrDefault());
                db.SaveChanges();
                lBox1.Items.Refresh();
                lBox2.Items.Clear();
                lBox1.SelectionChanged += LBox1_SelectionChanged;
            }

        }

        private void BtnAddAuthor_Click(object sender, RoutedEventArgs e)
        {
            var AuthorWindow = new AddAuthor();
            AuthorWindow.Show();
            this.Close();
        }

        private void LBoxAuthor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Author author;
            author = (Author)lBoxAuthor.SelectedItem;
            lBox2.Items.Clear();
            lBox2.Items.Add(author.AuthorID);
            lBox2.Items.Add(author.AuthorName);
            lBox2.Items.Add(author.DateOfBirth);
            lBox2.Items.Add(author.Book);
            using (var db = new BookShelfContext())
            {
                
            }
        }
    }

    public class Author
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }

        public Book Book { get; set; }
    }

    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookGenre { get; set; }
        public int Quantity { get; set; }

        public ICollection<Author> Authors { get; set; }
    }

    public class BookShelfContext : DbContext
    {
        public BookShelfContext() : base("Tyrone'sBookDB") { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
