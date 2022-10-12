using Microsoft.AspNetCore.Mvc;
using StudentsAPI.Data;

namespace StudentsAPI.Controllers
{
    [ApiController]
    [Route("api/[constroller]")]
    public class StudentsController : Controller
    {
        private readonly StudentsAPIDBContext dbContext;
        public StudentsController(StudentsAPIDBContext dbContext)
        {

        }
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(dbContext.Students.ToList());
        }
    }
}
