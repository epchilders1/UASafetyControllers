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
    [Route("v1/landmarks/[controller]")]
    internal class LandmarkImagesController : ControllerBase
    {
        [HttpPost("{buildingId}")]
        //User Stories
        //LM003: Create LandmarkImage
        public IActionResult CreateLandmarkImage(int buildingId, [FromBody] byte[] image)
        {
            Console.WriteLine($"Creating landmark image for building ID: {buildingId}");
            return Ok($"Created Landmark Image for Building ID {buildingId}");
        }
        [HttpGet]
        //User Stories
        //LM003: Get all LandmarkImages
        public IActionResult GetAllLandmarkImages()
        {
            Console.WriteLine("Getting all landmark images...");
            return Ok("All landmark images retrieved successfully.");
        }
        [HttpGet("{buildingId}")]
        //User Stories
        //LM003: Get LandmarkImages by building ID
        public IActionResult GetLandmarkImagesByBuildingId(int buildingId)
        {
            Console.WriteLine($"Getting landmark images for building ID: {buildingId}");
            return Ok($"Landmark Images for Building ID {buildingId} retrieved successfully.");
        }
        [HttpDelete("{imageId}")]
        //User Stories
        //LM003: Delete LandmarkImage
        public IActionResult DeleteLandmarkImage(int imageId)
        {
            Console.WriteLine($"Deleting landmark image with ID: {imageId}");
            return Ok($"Deleted Landmark Image with ID {imageId}");
        }
    }
}
