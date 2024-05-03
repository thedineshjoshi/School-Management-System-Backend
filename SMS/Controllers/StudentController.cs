using Microsoft.AspNetCore.Mvc;
using SMS.Data;
using SMS.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public ApplicationDbContext db;
        public StudentController(ApplicationDbContext db)
        {
            this.db = db;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [Route("PostStudent")]
        [HttpPost]
        public IActionResult PostStudent([FromBody] Student student)
        {
            Student obj = new Student();
            obj.FirstName = student.FirstName;
            obj.LastName = student.LastName;
            db.Add(student);
            db.SaveChanges();
            return Ok(student);

        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
