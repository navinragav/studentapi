namespace BetterEnglishAPI.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BetterEnglishAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BetterEnglishAPI.Models.ApplicationDbContext context)
        {
            context.Students.AddOrUpdate(
                  p => p.StudentID,
                 new Student { StudentID = "123", Date = DateTime.Parse("2016-09-01"), FirstName = "Carson", LastName = "Alexander", DOB = DateTime.Parse("1980-09-01"), Address = "23 Mount estuce,Tyrrelstown", Education = "Degree", ContactNumber = 0832280464 },
                      new Student { StudentID = "124", Date = DateTime.Parse("2016-11-07"), FirstName = "Aren", LastName = "Harbor", DOB = DateTime.Parse("1982-08-11"), Address = "45 Amiens street,Blanchardstown", Education = "Degree", ContactNumber = 0832280422 },
                 new Student { StudentID = "125", Date = DateTime.Parse("2017-03-31"), FirstName = "Gim", LastName = "Khan", DOB = DateTime.Parse("1981-02-21"), Address = "10 Anglesa Road,Lucan", Education = "Degree", ContactNumber = 0832280432 },
                 new Student { StudentID = "126", Date = DateTime.Parse("2016-08-21"), FirstName = "Him", LastName = "Lee", DOB = DateTime.Parse("1975-03-14"), Address = "93 baggot street,Hollistown", Education = "Degree", ContactNumber = 0832280467 },
                 new Student { StudentID = "127", Date = DateTime.Parse("2017-06-01"), FirstName = "Tim", LastName = "Aboullov", DOB = DateTime.Parse("1971-09-21"), Address = "62 Dame street,Tallaght", Education = "Degree", ContactNumber = 0832280424 },
                 new Student { StudentID = "128", Date = DateTime.Parse("2016-12-30"), FirstName = "Eric", LastName = "Faherty", DOB = DateTime.Parse("1969-10-07"), Address = "11 ballentree crescent,woodstown", Education = "Degree", ContactNumber = 0832280498 },
                 new Student { StudentID = "129", Date = DateTime.Parse("2016-04-18"), FirstName = "Edmount", LastName = "Harbor", DOB = DateTime.Parse("1977-08-20"), Address = "89 Mountrise,knocklyn", Education = "Degree", ContactNumber = 0832280465 },
                 new Student { StudentID = "130", Date = DateTime.Parse("2017-07-27"), FirstName = "Mathew", LastName = "Roger", DOB = DateTime.Parse("1985-12-01"), Address = "120 oConnor street,dublin", Education = "Degree", ContactNumber = 0832280433 },
                 new Student { StudentID = "131", Date = DateTime.Parse("2016-02-19"), FirstName = "Gemini", LastName = "Khan", DOB = DateTime.Parse("1984-05-28"), Address = "52 Mainstreet,Ongar", Education = "Degree", ContactNumber = 0832280482 });


            context.Courses.AddOrUpdate(
              p => p.CourseID,

             new Course { CourseID = "121", scheduleIn = DateTime.Parse("2017-06-01"), scheduleEnd = DateTime.Parse("2017-08-03"), cardNo = "3424567890123456", ExpiresDate = DateTime.Parse("2020-10-01"), CardName = "Navin", CVN = 123 },
             new Course { CourseID = "139", scheduleIn = DateTime.Parse("2017-06-20"), scheduleEnd = DateTime.Parse("2017-08-14"), cardNo = "9874567890123451", ExpiresDate = DateTime.Parse("2018-03-01"), CardName = "Raman", CVN = 989 },
            new Course { CourseID = "156", scheduleIn = DateTime.Parse("2017-06-30"), scheduleEnd = DateTime.Parse("2017-08-28"), cardNo = "3214567890123458", ExpiresDate = DateTime.Parse("2019-04-01"), CardName = "Selvi", CVN = 189 });


            context.Enrollments.AddOrUpdate(
              p => p.EnrollmentID,


                new Enrollment { EnrollmentID = "X123" },
            new Enrollment { EnrollmentID = "X256" },
             new Enrollment { EnrollmentID = "X356" },
              new Enrollment { EnrollmentID = "X139" },
               new Enrollment { EnrollmentID = "X134" });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
