using Azure.Identity;
using Microsoft.AspNetCore.Mvc;
using SMS.Data;
using SMS.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        public ApplicationDbContext db;
        // GET: api/<AuthenticationController>
        public AuthenticationController(ApplicationDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AuthenticationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AuthenticationController>
        [Route("SignUp")]
        [HttpPost]
        public IActionResult SignUp([FromBody] Register register)
        {
          Register obj = new Register();
            obj.firstName = register.firstName;
            obj.lastName = register.lastName;
            obj.phoneNumber = register.phoneNumber;
            obj.userName = register.userName;
            obj.password = register.password;
            obj.address = register.address;
            obj.email = register.email;
            db.Add(obj);
            db.SaveChanges();
            return Ok();



        }

        // PUT api/<AuthenticationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuthenticationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
