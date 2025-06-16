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

    internal class CampusAlertController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCampusAlertConfiguration()
        {
            Console.WriteLine("Getting current campus alert configuration");
            return Ok("Successfully retrieved campus alert configuration");
        }
        [HttpGet]
        //User stories
        //CA004: Get active campus alerts
        public IActionResult GetActiveCampusAlerts()
        {
            Console.WriteLine("Getting active campus alerts");
            return Ok("Successfully retrieved active campus alerts");
        }
        [HttpGet]
        //User stories
        //CA004: Get recent campus alert activity to have paper trail
        public IActionResult GetRecentCampusAlertActivity()
        {
            Console.WriteLine("Getting recent campus alert activity");
            return Ok("Successfully retrieved recent campus aler activity");
        }
        [HttpPost]
        //User stories
        //CA001: Choose which weather/campus alert notifications come through to the user
        public IActionResult CreateCampusAlertConfiguration(WeatherNotificationConfigurations configuration)
        {
            Console.WriteLine($"Creating new campus alert configuration: {configuration}");
            return Ok($"Successfully created campus alert configuration: {configuration}");
        }
        [HttpGet]
        //User stories
        //CA008: Get campus alert configuration (and visualize on map)
        public IActionResult GetCampusAlertConfigurationMap()
        {
            Console.WriteLine("Getting campus alert configuration map");
            return Ok("Successfully retrieved campus alert configuration map");
        }
        [HttpPost]
        //User stories
        //CA002: Create a new campus alert
        public IActionResult CreateCampusAlert(CampusAlerts alert)
        {
            Console.WriteLine($"Creating new campus alert: {alert}");
            return Ok($"Successfully created campus alert: {alert}");
        }
        [HttpPost]
        //User Stories
        //CA006: Schedule a campus alert
        public IActionResult ScheduleCampusAlert()
        {
            Console.WriteLine("Scheduling a campus alert");
            return Ok("Successfully scheduled campus alert");
        }
        [HttpPut("{id}")]
        //User Stories
        //CA003: Update a campus alert
        public IActionResult UpdateCampusAlert(int id, CampusAlerts newAlert)
        {
            Console.WriteLine($"Updating campus alert with id {id} to {newAlert}");
            return Ok($"Updated campus alert with id {id} to {newAlert}");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCampusAlert(int id)
        //User Stories
        //CA003: Delete a campus alert
        {
            Console.WriteLine($"Deleting campus alert with id {id}");
            return Ok($"Successfully deleted campus alert with id {id}");
        }
    }
}
