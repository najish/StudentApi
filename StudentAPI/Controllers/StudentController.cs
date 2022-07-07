using Microsoft.AspNetCore.Mvc;
using StudentAPI.Repository;
using StudentAPI.ViewModels;
using System.Threading.Tasks;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository repo;

        public StudentController(IStudentRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var list = await repo.GetStudents();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var list = await repo.GetStudent(id);
            return Ok(list);
        }


        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody]StudentViewModel model)
        {
            var student = await repo.AddStudent(model);
            return CreatedAtAction(nameof(AddStudent), student);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateStudent([FromRoute]int id,[FromBody]StudentViewModel model)
        {
            var student = await repo.UpdateStudent(id,model);
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent([FromRoute]int id)
        {
            await repo.DeleteStudent(id);
            return Ok();
        }
    }
}
