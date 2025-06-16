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
    internal class LandmarkGroupingsController : ControllerBase
    {
        [HttpPost]
        //User stories
        //LM005: Create landmark grouping
        public IActionResult CreateLandmarkGrouping(LandmarkGroupings grouping)
        {
            Console.WriteLine($"Creating Landmark Grouping {grouping}");
            return Ok($"Landmark Grouping Created {grouping}");
        }
        [HttpGet]
        //User stories
        //LM005: Get all landmark groupings
        public IActionResult GetLandmarkGroupings()
        { 
            Console.WriteLine("Getting all landmark groupings");
            return Ok($"Successfully got all landmark groupings");
        }
        [HttpGet("{landmarkId}")]
        //User stories
        //LM005: Get landmark grouping by landmarkId
        public IActionResult GetLandmarkGroupingByLandmarkId(int landmarkId)
        {
            Console.WriteLine($"Getting landmark grouping with landmarkId {landmarkId}");
            return Ok($"Landmark Grouping for landmarkId {landmarkId}");
        }
        [HttpPut("{groupingId}")]
        //User stories
        //LM005: Update landmark grouping
        public IActionResult UpdateLandmarkGrouping(int groupingId, LandmarkGroupings grouping)
        {
            Console.WriteLine($"Updating Landmark Grouping with ID {groupingId}");
            return Ok($"Landmark Grouping with ID {groupingId} updated to {grouping}");
        }
        [HttpDelete("{groupindId}")]
        //User stories
        //LM005: Delete landmark grouping
        public IActionResult DeleteLandmarkGrouping(int groupingId)
        {
            Console.WriteLine($"Deleting Landmark Grouping with ID {groupingId}");
            return Ok($"Landmark Grouping with ID {groupingId} deleted");
        }
        [HttpDelete("batch")]
        //LM007: Delete multiple Landmark groupings
        public IActionResult DeleteLandmarkGroupings([FromBody] List<LandmarkGroupings> landmarkGroupings)
        {
            Console.WriteLine($"Deleting {landmarkGroupings.Count} landmarks");
            return Ok($"Deleteed {landmarkGroupings.Count} landmarks successfully.");
        }
    }
}
