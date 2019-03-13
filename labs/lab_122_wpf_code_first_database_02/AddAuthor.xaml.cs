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
    /// Interaction logic for AddAuthor.xaml
    /// </summary>
    public partial class AddAuthor : Window
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            var HomeWindow = new MainWindow();
            HomeWindow.Show();
            this.Close();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new BookShelfContext())
            {
                var author1 = new Author
                {
                    AuthorName = tAuthorName.Text,
                    DateOfBirth = Convert.ToDateTime(tDOB.Text),
                    //Book = Textbox03.Text,

                };
                db.Authors.Add(author1);
                db.SaveChanges();
            }
        }
    }
}
