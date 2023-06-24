using BlogApi.DataAcseesLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]

        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values = c.Employers.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult EmployeeAdd(Employer employee)
        {
            using var c = new Context();
            c.Add(employee);
            c.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult EmployeeGet(int id)
        {
            using var c = new Context();
            var employee = c.Employers.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {
            using var c = new Context();
            var employee = c.Employers.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            c.Remove(employee);
            c.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult EmployeeUpdate(Employer employee)
        {
            using var c = new Context();
            var emp = c.Employers.Find(employee.Id);
            if (employee == null)
            {
                return NotFound();
            }
            emp.Name = employee.Name;
            c.Update(emp);
            c.SaveChanges();
            return Ok();
        }
    }
}

