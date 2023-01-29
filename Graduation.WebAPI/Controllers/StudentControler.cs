//using Azure.Core;
//using DataAccessLayer.Entities;
//using Graduation.DAL.UnitOfWork;
//using Microsoft.AspNetCore.Mvc;

//namespace Graduation.WebAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class StudentControler : ControllerBase
//    {
//        private readonly IUnitOfWork _context;
//        public StudentControler(IUnitOfWork context)
//        {
//            _context = context;
//        }

//        private static List<StudentEntity> Users = new List<StudentEntity>
//            {
//                new StudentEntity
//                {
//                Name = "Angelina",
//                Surname = "Joly",
//                Patronymic = "AD3568",
//                IdentityNumber = "+89652135684",
//                Email = "sfdfarfrf.com",
//                 }
//            };

//        [HttpGet]
//        public async Task<ActionResult<List<StudentEntity>>> Get()
//        {
//            return Ok();
//        }

//        //[HttpGet("(id)")]
//        //public async Task<ActionResult<EmployeeRequest>> Get(int id)
//        //{
//        //    var employee = await _context.Employees.FindAsync(id);
//        //    if (employee == null)
//        //        return BadRequest("Not found");
//        //    return Ok(employee);
//        //}

//        //[HttpPost]
//        //public async Task<ActionResult<List<EmployeeRequest>>> AddUsers(EmployeeRequest employee)
//        //{
//        //    _context.Employees.Add(employee);
//        //    await _context.SaveChangesAsync();

//        //    return Ok(await _context.Employees.ToListAsync());
//        //}

//        [HttpPut]
//        public async Task<ActionResult<List<StudentEntity>>> UpdateUsers(StudentEntity student)
//        {
//            var employee = Users.Find(h => h.Id == student.Id);
//            if (employee == null)
//                return BadRequest("Not found");

//            employee.Name = student.Name;
//            employee.Surname = student.Surname;
//            employee.Patronymic = student.Patronymic;
//            employee.IdentityNumber = student.IdentityNumber;
//            employee.Email = student.Email;
//            return Ok(Users);
//        }


//        //[HttpDelete("(id)")]
//        //public async Task<ActionResult<List<EmployeeRequest>>> Delete(int id)
//        //{
//        //    var employee = Users.Find(h => h.ID == id);
//        //    if (employee == null)
//        //        return BadRequest("Not found");
//        //    Users.Remove(employee);
//        //    return Ok(Users);
//        //}

//    }
//}