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
    [Authorize]
    [Route("v1/[controller]")]
    internal class AmenityCategoriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllAmenityCategories()
        {
            Console.WriteLine("Getting all amenity categories");
            return Ok("Successfully retrieved all amenity categories");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateAmenityCategoryById(int id, AmenityCategories newCategory)
        {
            Console.WriteLine($"Updating amenity category with ID: {id} to {newCategory}");
            return Ok($"Successfully updated amenity category with ID: {id} to {newCategory}");
        }
        [HttpPost]
        //User stories
        //AM001: Create Amenity Category
        public IActionResult CreateAmenityCategory(AmenityCategories category)
        {
            Console.WriteLine($"Creating a new amenity category: {category}");
            return Ok($"Successfully created a new amenity category: {category}");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAmenityCategoryById(int id)
        {
            Console.WriteLine($"Deleting amenity category with ID: {id}");
            return Ok($"Successfully deleted amenity category with ID: {id}");
        }
    }
}
