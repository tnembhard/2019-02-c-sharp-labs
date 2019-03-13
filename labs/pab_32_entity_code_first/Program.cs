using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace pab_32_entity_code_first
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CollegeContext())
            {
                var student01 = new Student
                {
                    StudentID = 12345676,
                    StudentName = "Steve Bob",
                    DateOfBirth = new DateTime(01/01/2010),
                };
                db.Students.Add(student01);
                db.SaveChanges();
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
        public CollegeContext() : base() { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
    }
}
