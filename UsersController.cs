using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using UASafety.Refactor.DataAccess.Models;
using Microsoft.Extensions.Options;
using System.Web.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using AuthorizeAttribute = Microsoft.AspNetCore.Authorization.AuthorizeAttribute;
using HttpGet = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPost = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using HttpPut = Microsoft.AspNetCore.Mvc.HttpPutAttribute;
using HttpDelete = Microsoft.AspNetCore.Mvc.HttpDeleteAttribute;
using ControllerBase = Microsoft.AspNetCore.Mvc.ControllerBase;

namespace UASafety.Refactor.DataAccess.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    [Authorize]
    internal class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            Console.WriteLine("Fetching all users...");
            return Ok("Successfully fetched all users.");
        }
        [HttpGet]
        //User Stories
        //US004: Get recent user updates for a paper trail of activities
        public IActionResult GetRecentUserUpdates()
        {
            Console.WriteLine("Fetching recent user updates...");
            return Ok("Successfully fetched recent user updates.");
        }
        [HttpPut("{id}")]
        //User Stories
        //US001: Add/remove authorized user perms
        public IActionResult UpdateUser(int id, Users user)
        {
            Console.WriteLine($"Updating user with ID: {id}");
            return Ok($"User with ID {id} updated successfully.");
        }
        [HttpPost]
        //User Stories
        //US002: Create a user
        public IActionResult CreateUser(Users user)
        {
            Console.WriteLine($"Creating a new user {user}");
            return Ok($"Created new user: {user}");
        }
        [HttpDelete("{id}")]
        //User Stories
        //US002: Delete a user
        public IActionResult DeleteUser(int id)
        {
            Console.WriteLine($"Deleting user with ID: {id}");
            return Ok($"Deleted user with id {id} successfully.");
        }
    }
}
