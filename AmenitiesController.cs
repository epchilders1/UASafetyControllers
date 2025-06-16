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
    public class AmenitiesController : ControllerBase
    {
        [HttpGet]
        //User stories
        //LM006: Get amenities for a landmark
        public IActionResult GetAmenities(int landmarkId)
        {
            Console.WriteLine($"Fetching amenities for landmark with ID: {landmarkId}");
            return Ok($"Successfully fetched amenities for landmark {landmarkId}");
        }
        [HttpGet]
        public IActionResult GetAllAmenities()
        {
            Console.WriteLine("Fetching all amenities");
            return Ok("Successfully fetched all amenities");
        }
        [HttpPost]
        public IActionResult CreateAmenitiy(int amenityId)
        {
            Console.WriteLine($"Creating amenity for landmark with ID: {amenityId}");
            return Ok($"Successfully created amenity for landmark {amenityId}");
        }
        [HttpPut("{id}")]
        //User Stories
        //AM003: Update amenity
        public IActionResult UpdateAmenity(int amenityId, Amenities newAmenity)
        {
            Console.WriteLine($"Updating amenity with ID: {amenityId} to {newAmenity}");
            return Ok($"Successfully updated amenity with ID {amenityId} to {newAmenity}");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAmenity(int amenityId)
        {
            Console.WriteLine($"Deleting amenity with ID: {amenityId}");
            return Ok($"Successfully deleted amenity with ID {amenityId}");
        }

    }
}
