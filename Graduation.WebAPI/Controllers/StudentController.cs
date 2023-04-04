using DataAccessLayer.Entities;
using Graduation.BLL.BLConract;
using Gradutation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using System.Data;

namespace Graduation.WebAPI.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentBL studentBL;

        public StudentController(IStudentBL studentBL)
        {
            this.studentBL = studentBL;
        }

        [HttpPost("Student/Insert")]
        public void Save([FromQuery] StudentModel student)
        {
            studentBL.Insert(student);
        }

        [HttpGet("Student/GetByIdentityNumber")]
        public async Task<IActionResult> GetByIdentityNumber(string IdentityNumber)
        {
            var user = studentBL.GetByIdentityNumber(IdentityNumber);
            
            if (user is null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpDelete("Student/Remove")]
        public async Task<IActionResult> RemoveUser([FromQuery] string IdentityNumber)//AK4525878
        {
            var user = studentBL.GetByIdentityNumber(IdentityNumber);
            if (user is null)
            {
                return NotFound();
            }
            studentBL.Remove(IdentityNumber);
            return Ok();
        }

        [HttpPut("Student/Update")]
        public async Task<IActionResult> Update([FromQuery] StudentModel student)
        {
            var usert = studentBL.GetByIdentityNumber(student.IdentityNumber);
            if (usert is null)
            {
                return NotFound();
            }
            studentBL.Update(student);
            return Ok();
        }

        [HttpPut("Student/Graded")]
        public async Task<IActionResult> Update1([FromQuery] GradedModel student)
        {
            var usert = studentBL.GetByIdentityNumber(student.IdentityNumber);
            if (usert is null)
            {
                return NotFound();
            }
            studentBL.Update1(student);
            return Ok();
        }
    }
}
