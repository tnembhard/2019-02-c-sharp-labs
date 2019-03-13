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

namespace lab_122_wpf_code_first_database
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
            List<Student> students = new List<Student>();
            using (var db = new CollegeContext())
            {
                students = db.Students.ToList<Student>();
            }
            lBox1.ItemsSource = students;
            lBox1.DisplayMemberPath = "StudentName";
            lBox1.SelectionChanged += LBox1_SelectionChanged;
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
            Student student;
            student = (Student)lBox1.SelectedItem;
            lBox2.Items.Clear();
            lBox2.Items.Add(student.StudentID);
            lBox2.Items.Add(student.StudentName);
            lBox2.Items.Add(student.Height);
            lBox2.Items.Add(student.Weight);    
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {            
            using (var db = new CollegeContext())
            {
                lBox1.SelectionChanged -= LBox1_SelectionChanged;
                Student s = new Student();
                s = lBox1.SelectedItem as Student;
                db.Students.Remove(db.Students.Where(student => student.StudentID == s.StudentID).FirstOrDefault());

                db.SaveChanges();
                lBox1.Items.Refresh();
                lBox2.Items.Clear();
                lBox1.SelectionChanged += LBox1_SelectionChanged;
            }

        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Qualification Qualification { get; set; }
    }

    public class Qualification
    {
        public int QualificationId { get; set; }
        public string QualificationName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }

    public class CollegeContext : DbContext
    {
        // Constructor method : bounce responsibility
        // back up to Entity DbContext to do all the hard work
        public CollegeContext() : base("TyronesEntityCodeFirst") { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
    }
}
