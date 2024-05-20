using EF_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<Student> Student { get; set; }

        public DbSet<Grade> Grade { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentID = 1, StudentName = "Pero", DateOfBirth = new DateTime(2003, 2, 20, 20, 53 ,19, 238), Height = 180, Weight = 80 },
                new Student { StudentID = 2, StudentName = "Ivan", DateOfBirth = new DateTime(2002, 7, 15, 20, 53, 19, 238), Height = 178, Weight = 75 },
                new Student { StudentID = 3, StudentName = "Nikolina", DateOfBirth = new DateTime(2002, 7, 21, 20, 53, 19, 238), Height = 168, Weight = 65 });






            modelBuilder.Entity<Grade>().HasData(
                new Grade { GradeId = 1, GradeName = "Programsko inženjerstvo", Section = "Računarstvo", StudentId = 1 },
                new Grade { GradeId = 2, GradeName = "Sistemsko inženjerstvo", Section = "Računarstvo", StudentId = 1 },
                new Grade { GradeId = 3, GradeName = "Računalno inženjerstvo", Section = "Računarstvo", StudentId = 1 },
                new Grade { GradeId = 4, GradeName = "Automatika i robotika", Section = "Informacijska i komunikacijska tehnologija", StudentId = 3 },
                new Grade { GradeId = 5, GradeName = "Komunikacijske i svemirske tehnologije", Section = "Informacijska i komunikacijska tehnologija", StudentId = 3 },
                new Grade { GradeId = 6, GradeName = "Elektroenergetika", Section = "Elektrotehnika", StudentId = 2 },
                new Grade { GradeId = 7, GradeName = "Elektronika", Section = "Elektrotehnika", StudentId = 2 });


            //nakon ovoga ide migracija po starom:

            //add-migration InitialMigration
            //update-database


        }

    }



}
