using IntegrationLab;
using IntegrationLab.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using oops;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentDbController : ControllerBase
    {
        LabApi context = null;
        public StudentDbController(LabApi ctx)
        {
            context = ctx;
        }
    
        [HttpPost("/insert")]
        public IActionResult InsertEmp([FromBody] StudentController emp)
        {
            context.Student.Add(emp); 
            context.SaveChanges();
            return Created("/insert",emp);
        }

        [HttpGet("/all")]
        public IActionResult GetEmp()
        {
           return Ok(context.Employees.ToList());
        }
    }
}
