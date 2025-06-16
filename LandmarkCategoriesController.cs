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
    internal class LandmarkCategoriesController : ControllerBase
    {
        [HttpPost]
        //User Stories
        //LM004: Create Landmark Category
        public IActionResult CreateLandmarkCategory(LandmarkCategories category)
        {
            Console.WriteLine($"Creating landmark category: {category}");
            return Ok($"Created Landmark Category: {category}");
        }
        [HttpGet]
        //User Stories
        //LM004: Get all Landmark Categories
        public IActionResult GetAllLandmarkCategories()
        {
            Console.WriteLine("Getting all landmark categories...");
            return Ok("All landmark categories retrieved successfully.");
        }
        [HttpGet("{id}")]
        //User Stories
        //LM004: Get Landmark Category by landmark ID
        public IActionResult GetLandmarkCategoryById(int landmarkId)
        {
            Console.WriteLine($"Getting landmark category with landmark ID: {landmarkId}");
            return Ok($"Landmark Category with ID {landmarkId} retrieved successfully.");
        }

        [HttpPut("{id}")]
        //User Stories
        //LM004: Update Landmark Category
        public IActionResult UpdateLandmarkCategory(int id, LandmarkCategories category)
        {
            Console.WriteLine($"Updating landmark category with ID: {id}");
            return Ok($"Updated Landmark Category with ID {id}: {category}");
        }

        [HttpDelete("{id}")]
        //User Stories
        //LM004: Delete Landmark Category
        public IActionResult DeleteLandmarkCategory(int id)
        {
            Console.WriteLine($"Deleting landmark category with ID: {id}");
            return Ok($"Deleted Landmark Category with ID {id}");
        }
        [HttpDelete("batch")]
        //LM007: Delete multiple Landmark Categories
        public IActionResult DeleteLandmarkCategories([FromBody] List<LandmarkCategories> landmarkCategories)
        {
            Console.WriteLine($"Deleting {landmarkCategories.Count} landmarks");
            return Ok($"Deleteed {landmarkCategories.Count} landmarks successfully.");
        }
    }
}
