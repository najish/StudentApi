using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Data;
using StudentAPI.Models;
using StudentAPI.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext context;

        public StudentRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Student>> GetStudents()
        {
            var list = await context.Students.ToListAsync();
            return list;
        }

        
        public async Task<Student> GetStudent(int id)
        {
            var student = await context.Students.FindAsync(id);
            return student;
        }

        public async Task<Student> AddStudent(StudentViewModel model)
        {
            var student = new Student { Name = model.Name,Address = model.Address};

            context.Students.Add(student);
            await context.SaveChangesAsync();
            return student;
        }


        public async Task<Student> UpdateStudent(int id,StudentViewModel model)
        {
            var student = context.Students.Find(id);
            if(student != null)
            {
                student.Name = model.Name;
                student.Address = model.Address;
            }
            context.Update(student);
            await context.SaveChangesAsync();
            return student;
        }

        public async Task DeleteStudent(int id)
        {
            var student = await context.Students.FindAsync(id);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }
    }
}
