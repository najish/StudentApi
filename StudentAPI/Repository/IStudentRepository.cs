using StudentAPI.Models;
using StudentAPI.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAPI.Repository
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<Student> GetStudent(int id);
        Task DeleteStudent(int id);
        Task<Student> AddStudent(StudentViewModel student);
        Task<Student> UpdateStudent(int id,StudentViewModel student);
    }
}
