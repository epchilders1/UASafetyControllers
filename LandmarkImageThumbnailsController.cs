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
    internal class LandmarkImageThumbnailsController : ControllerBase
    {
        [HttpPost("{imageThumbnailId}")]
        //User Stories
        //LM003: Create LandmarkImageThumbnail
        public IActionResult CreateLandmarkImageThumbnail(int imageThumbnailId, [FromBody] byte[] thumbnail)
        {
            Console.WriteLine($"Creating landmark image thumbnail with ID: {imageThumbnailId}");
            return Ok($"Created Landmark Image Thumbnail with ID {imageThumbnailId}");
        }
        [HttpGet]
        public IActionResult GetAllLandmarkImageThumbnails()
        {
            Console.WriteLine("Getting all landmark image thumbnails...");
            return Ok("All landmark image thumbnails retrieved successfully.");
        }
        [HttpGet("{buildingId}")]
        //User Stories
        //LM003: Get LandmarkImageThumbnails by building ID
        public IActionResult GetLandmarkImageThumbnailsByBuildingId(int buildingId)
        {
            Console.WriteLine($"Getting landmark image thumbnails for building ID: {buildingId}");
            return Ok($"Landmark Image Thumbnails for Building ID {buildingId} retrieved successfully.");
        }
        [HttpDelete("{thumbnailId}")]
        //User Stories
        //LM003: Delete LandmarkImageThumbnail
        public IActionResult DeleteLandmarkImageThumbnail(int thumbnailId)
        {
            Console.WriteLine($"Deleting landmark image thumbnail with ID: {thumbnailId}");
            return Ok($"Deleted Landmark Image Thumbnail with ID {thumbnailId}");
        }
    }
}
