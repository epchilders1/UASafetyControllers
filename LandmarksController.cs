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
    //[Authorize(Policy = "Admin")]
    [ApiController]
    [Authorize]
    [Route("v1/[controller]")]

    public class LandmarksController : ControllerBase
    {
        [HttpGet]
        //LM008 Get all landmarks to filter/search through them
        //LM009 Get all landmarks to display them as pins on a map
        public IActionResult GetAllLandmarks()
        {
            Console.WriteLine("Getting all landmarks...");
            return Ok("All landmarks retrieved successfully.");
        }

        [HttpGet("{id}")]
        public IActionResult GetLandmarkById(int id)
        {
            Console.WriteLine($"Getting landmark with ID: {id}");
            return Ok($"Landmark with ID {id} retrieved successfully.");
        }

        [HttpPost]
        public IActionResult CreateLandmark(Landmarks landmark)
        {
            Console.WriteLine($"Creating landmark: {landmark}");
            return Ok($"Created Landmark: {landmark}");
        }

        [HttpPost("batch")]
        //User Stories
        //LM001,LM002: Batch Upload Landmarks from CSV/XLSX File 
        public IActionResult CreateLandmarksBatch([FromBody] List<Landmarks> landmarks)
        {
            Console.WriteLine($"Creating {landmarks.Count} landmarks from csv/xlsx file");
            return Ok($"Created {landmarks.Count} landmarks successfully.");
        }

        [HttpPut("{id}")]
        //User Stories
        //LM004: Reassign Landmark Category for individual landmark
        //LM005: Reassign Landmark Grouping for individual landmark
        //AM002: Add new amenity to existing landmark
        //AM003: Update existing amenity for landmark
        //AM004: Bulk add amenities to existing landmark
        public IActionResult UpdateLandmark(int id, Landmarks landmark)
        {
            Console.WriteLine($"Updating landmark with ID: {id}");
            return Ok($"Updated Landmark with ID {id}: {landmark}");
        }

        [HttpDelete("batch")]
        //User Stories
        //LM001,LM002: Batch Delete Landmarks
        public IActionResult DeleteLandmarks([FromBody] List<Landmarks> landmarks)
        {
            Console.WriteLine($"Deleting {landmarks.Count} landmarks");
            return Ok($"Deleteed {landmarks.Count} landmarks successfully.");
        }
        [HttpGet("{landmarkId}/amenities")]
        //User Stories
        //LM006: Get Amenities for Landmark
        public IActionResult GetLandmarkAmenities(int landmarkId)
        {
            Console.WriteLine($"Getting amenities for landmark with ID: {landmarkId}");
            return Ok($"Amenities for landmark with ID {landmarkId} retrieved successfully.");
        }

        //LandmarkImages section

        [HttpPost("{landmarkId}")]
        //User Stories
        //LM003: Create LandmarkImage
        public IActionResult CreateLandmarkImage(int landmarkId, [FromBody] byte[] image)
        {
            Console.WriteLine($"Creating landmark image for building ID: {landmarkId}");
            return Ok($"Created Landmark Image for Building ID {landmarkId}");
        }
        [HttpGet("{landmarkId}")]
        //User Stories
        //LM003: Get all LandmarkImages for a certain landmark
        public IActionResult GetAllLandmarkImagesById(int landmarkId)
        {
            Console.WriteLine($"Getting all landmark images for landmark with id {landmarkId}");
            return Ok($"All landmark images retrieved successfully for landmark with id {landmarkId}");
        }
        [HttpDelete("{imageId}")]
        //User Stories
        //LM003: Delete LandmarkImage
        public IActionResult DeleteLandmarkImage(int imageId)
        {
            Console.WriteLine($"Deleting landmark image with ID: {imageId}");
            return Ok($"Deleted Landmark Image with ID {imageId}");
        }

        //LandmarkImageThumbnails section

        [HttpPost("{buildingId}")]
        //User Stories
        //LM003: Create LandmarkImageThumbnail
        public IActionResult CreateLandmarkImageThumbnail(int buildingId, [FromBody] byte[] thumbnail)
        {
            Console.WriteLine($"Creating landmark image thumbnail with building ID: {buildingId}");
            return Ok($"Created Landmark Image Thumbnail with building ID {buildingId}");
        }
        [HttpGet("{landmarkId}")]
        //User Stories
        //LM003: Get LandmarkImageThumbnails by building ID
        public IActionResult GetLandmarkImageThumbnailsByBuildingId(int landmarkId)
        {
            Console.WriteLine($"Getting landmark image thumbnails for building ID: {landmarkId}");
            return Ok($"Landmark Image Thumbnails for Building ID {landmarkId} retrieved successfully.");
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

