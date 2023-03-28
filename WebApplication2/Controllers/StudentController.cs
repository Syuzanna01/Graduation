using DataAccessLayer.Entities;
using Graduation.BLL.BLConract;
using Gradutation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Graduation.WebAPI.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> logger;
        private readonly IStudentBL studentBL;

        public StudentController(ILogger<StudentController> logger, IStudentBL studentBL)
        {
            this.logger = logger;
            this.studentBL = studentBL;
        }

        [HttpPost("Student/Insert")]
        public void Save([FromQuery] StudentModel student)
        {
            studentBL.Insert(student);
        }

        [HttpGet("Student/Get")]
        public async Task<IActionResult> Get(string Id)
        {
            var usert = studentBL.GetById(Id);
            if (usert is null)
            {
                return NotFound();
            }
            return Ok(usert);
        }

        [HttpDelete("Student/Remove")]
        public async Task<IActionResult> RemoveUser([FromQuery] string id)
        {
            var usert = studentBL.GetById(id);
            if (usert is null)
            { 
                return NotFound();
            }
            studentBL.Remove(id);
            return Ok();
        }

        [HttpPut("Student/Update")]
        public async Task<IActionResult> Update([FromQuery] StudentModel student)
        {
            var usert = studentBL.GetById(student.IdentityNumber);
            if (usert is null)
            {
                return NotFound();
            }
            studentBL.Update(student);
            return Ok();
        }
    }
}
