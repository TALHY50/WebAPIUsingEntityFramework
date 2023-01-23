using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using WebAPIUsingEntityFramework.Interface;
using WebAPIUsingEntityFramework.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIUsingEntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly Istudent repository;
        public StudentController(Istudent repository)
        {
            this.repository = repository;
        }
        // GET: api/<Student>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return repository.GetAll();
        }
        // GET api/<STUDENTSController>/5
        [HttpGet("{id}")]
        public Student GetStudent(int id)
        {

            return repository.Get(id);
        }

        // POST api/<STUDENTSController>
        [HttpPost("post")]
        public void Post(Student student)
        {

            repository.Add(student);
        }

        // PUT api/<STUDENTSController>/5
        [HttpPut("{id}")]
        public void Put(int id, Student student)
        {
            student.Id = id;

            repository.Update(student);
        }

        // DELETE api/<STUDENTSController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
