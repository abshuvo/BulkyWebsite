using Microsoft.AspNetCore.Mvc;
using MyTestAPI.Data;
using MyTestAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        protected readonly StudentDbContext _context;
        public StudentsController(StudentDbContext context)
        {
            _context = context;
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _context.Students.ToList();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            //return _context.Students.Find(id);
            return _context.Students.FirstOrDefault(st => st.Id == id);
             
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        // PUT api/<StudentsController>/5
        [HttpPut]
        public void Put(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var student = _context.Students.FirstOrDefault(st => st.Id == id);
            _context.Remove(student);
            _context.SaveChanges();
        }
    }
}
