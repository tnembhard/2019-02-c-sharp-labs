using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace lab_32_entity_code_first_standard
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CollegeContext())
            {
                var student01 = new Student
                {
                    StudentName = "Steven Bobby",
                    DateOfBirth = null,
                };
                db.Students.Add(student01);
                db.SaveChanges();
            }

            List<Student> students = new List<Student>();
            using (var db = new CollegeContext())
            {
                students = db.Students.ToList<Student>();
            }
            students.ForEach(s => Console.WriteLine($"ID : {s.StudentID} Name : {s.StudentName} "));
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
