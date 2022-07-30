using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.DataModels;
using StudentAdminPortal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.Controllers
{   [Authorize]
    //[Route("api/v(version:apiVersion)/Users")]
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepos _userRepo;
        public UsersController(IUserRepos userRepo)
        {
            _userRepo = userRepo;
        }
       [HttpPost("authenticate")]
       // [Route("[controller]")]
        public IActionResult Authenticate([FromBody] User model)
        {
            var user = _userRepo.Authenticate(model.Username, model.Passeword);
            if (user == null)
            {
                return BadRequest(new { message = "Username or Password is incorrect" });

            }
           
            return Ok(user);
        }
    }
}
