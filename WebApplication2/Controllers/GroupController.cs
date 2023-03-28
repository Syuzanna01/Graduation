//using DataAccessLayer.Entities;
//using Graduation.BLL.AccountBL;
//using Graduation.BLL.BLConract;
//using Graduation.BLL.GroupBL;
//using Microsoft.AspNetCore.Mvc;

//namespace Graduation.WebAPI.Controllers
//{
//    [ApiController]
//    public class GroupController : Controller
//    {
//        private readonly ILogger<GroupController> logger;
//        private readonly IGroupBL groupBL;
//        public GroupController(ILogger<GroupController> logger, IGroupBL groupBL)
//        {
//            this.logger = logger;
//            this.groupBL = groupBL;
//        }

//        [HttpGet(Name = "GetId")]
//        public async Task<IActionResult> Get(int Id) 
//        {
//            var usert = groupBL.GetById(Id);
//            if (usert is null)
//            {
//                return NotFound();
//            }
//            return Ok(usert);
//        }

//        [HttpPost("Add")]
//        public void Save([FromBody] GroupModel group)
//        {
//            groupBL.Insert(group);
//        }

//        [HttpDelete("Remove")]
//        public async Task<IActionResult> RemoveUser(int id)
//        {
//            var usert = groupBL.GetById(id);
//            if (usert is null)
//            {
//                return NotFound();
//            }
//            groupBL.Remove(id);
//            return Ok();
//        }

//        [HttpDelete("Update")]
//        public async Task<IActionResult> Update(GroupModel student)
//        {
//            var usert = groupBL.GetById(student.Id); 
//            if (usert is null)
//            {
//                return NotFound();
//            }
//            groupBL.Update(student);
//            return Ok();
//        }

//    }
//}
