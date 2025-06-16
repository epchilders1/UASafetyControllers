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

    }
}
