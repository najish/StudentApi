using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.Data
{
    public static class SeedData
    {
        public static void StudentData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student[]
            {
                new Student
                {
                    Id = 1,
                    Name = "Najish Eqbal",
                    Address = "Rajabagicha"
                },
                new Student
                {
                    Id = 2,
                    Name = "Dilnawaz Alam",
                    Address = "RAfiganj"
                },
                new Student
                {
                    Id = 3,
                    Name = "Zafer Eqbal",
                    Address = "Daudnagar"
                },
                new Student
                {
                    Id = 4,
                    Name = "Ravish Kumar",
                    Address = "duniya mohalla"
                },
                new Student
                {
                    Id = 5,
                    Name = "Sanu RAj",
                    Address = "Market"
                }
            }) ;
        }
    }
}
