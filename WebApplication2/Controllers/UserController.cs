using BL.Core;
using Graduation.BLL.DTO.AuthModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Principal;

namespace Graduation.WebAPI.Controllers
{
    [Route("User")]
    [ApiController]
    public class UserController : Controller
    {
        private UserBL userBl = new UserBL();

        [HttpPost]
        [Route("Post")]        
        public async Task<IActionResult> AddUser([FromQuery] UserModel model)
        {
            //var user = GetCurrentUser();
            //if (!userBl.HasPermission(user.Username, "Admin"))
            //{
            //    throw new Exception("You have not permission");
            //}

            if (model == null) return BadRequest(ModelState);
            userBl.InsertUser(model);
            return Ok(model);
        }
        private UserModel GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                var userClaims = identity.Claims;
                return new UserModel
                {
                    Username = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value,                   
                };
            }
            return null;
        }
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateUsers([FromQuery] UserModel userInfo)
        {
            if (!userBl.UserExists(userInfo.Username))
            {
                return NotFound();
            }
            userBl.UpdateUser(userInfo);
            return Ok(userInfo);

        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> GetUser([FromQuery] string mail, string password)
        {
            var model = userBl.GetUser(mail, password);
            if (model is null)
            {
               throw new NullReferenceException();
            }
            return Ok(model);
        }

        [HttpDelete]
        [Route("Remove")]
        public async Task<IActionResult> RemoveUser(string username)
        {
            if (!userBl.UserExists(username))
            {
                return NotFound();
            }
            userBl.RemoveUser(username);
            return Ok();
        }
    }
}
