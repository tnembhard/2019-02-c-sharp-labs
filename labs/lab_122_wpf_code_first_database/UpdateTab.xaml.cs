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


namespace lab_122_wpf_code_first_database
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
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new CollegeContext())
            {
                var student01 = new Student
                {
                    StudentName = tStudentName.Text,
                    Height = Convert.ToDecimal(tStudentHeight.Text),
                    Weight = Convert.ToSingle(tStudentWeight.Text)               
                };
                db.Students.Add(student01);
                db.SaveChanges();
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            var HomeWindow = new MainWindow();
            HomeWindow.Show();
            this.Close();
        }
    }
}
