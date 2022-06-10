using Microsoft.EntityFrameworkCore;
using System;

namespace Demo.Data
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=AspSchool;Trusted_Connection=True;");
        }
        public DbSet<Student> students { get; set; }
    }
}
