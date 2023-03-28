//using Graduation.BLL.BLConract;
//using Gradutation.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace Graduation.WebAPI.Controllers
//{
//    [ApiController]
//    public class LecturerController : Controller
//    {
//        private readonly ILecturerBL lecturerBL;

//        public LecturerController(ILecturerBL lecturerBL)
//        {
//            this.lecturerBL = lecturerBL;
//        }

//        [HttpPost("Insert")]
//        public void Save([FromQuery] LecturerModel lecturer)
//        {
//            lecturerBL.Insert(lecturer);
//        }

//        [HttpGet("Get")]
//        public async Task<IActionResult> Get(string Id) //[FromBody] GroupEntity groupEntity
//        {
//            var usert = lecturerBL.GetById(Id);
//            if (usert is null)
//            {
//                return NotFound();
//            }
//            return Ok(usert);
//        }

//        [HttpDelete("Remove")]
//        public async Task<IActionResult> RemoveUser([FromQuery] string id)
//        {
//            var usert = lecturerBL.GetById(id);
//            if (usert is null)
//            {
//                return NotFound();
//            }
//            lecturerBL.Remove(id);
//            return Ok();
//        }

//        [HttpPut("Update")]
//        public async Task<IActionResult> Update([FromQuery] LecturerModel student)
//        {
//            var usert = lecturerBL.GetById(student.IdentityNumber);
//            if (usert is null)
//            {
//                return NotFound();
//            }
//            lecturerBL.Update(student);
//            return Ok();
//        }
//    }
//}
