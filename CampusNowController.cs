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
    [Route("api/[controller]")]
    internal class CampusNow : ControllerBase
    {
        [HttpGet]
        //User Stories
        //CN001: Get contact groups attached to the Campus Now page
        public IActionResult GetAttachedContactGroups()
        {
            Console.WriteLine("Fetching all contact groups attached to the About page...");
            return Ok("Successfully retrieved all contact groups attached to the About page");
        }
        [HttpGet]
        //User Stories
        //CN001: Get contacts attached to the Campus Now page
        public IActionResult GetAttachedContacts()
        {
            Console.WriteLine("Fetching all contacts attached to the About page...");
            return Ok("Successfully retrieved all contacts attached to the About page");
        }
        [HttpPut("{id}")]
        //User Stories
        //CN001: Update contact group
        //CN002: Specify that contact group is to appear on the Campus Now page
        public IActionResult UpdateContactGroup(ContactsGrouping grouping)
        {
            Console.WriteLine($"Updating contact group {grouping}");
            return Ok($"Successfully updated contact group {grouping}");
        }
        [HttpPut("{id}")]
        //User Stories
        //CN001: Update contact
        //CN002: Specify that contact is to appear on the Campus Now page

        public IActionResult UpdateContact(Contacts contact)
        {
            Console.WriteLine($"Updating contact group {contact}");
            return Ok($"Successfully updated contact group {contact}");
        }
        [HttpPost]
        //User Stories
        //CN001: Add contact group
        //CN002: Specify that contact group is to appear on the Campus Now page

        public IActionResult AddContactGroup(ContactsGrouping grouping)
        {
            Console.WriteLine($"Adding contact group {grouping}");
            return Ok($"Successfully added contact group {grouping}");
        }
        [HttpPost]
        //User Stories
        //CN001: Add contact
        //CN002: Specify that contact is to appear on the Campus Now page
        public IActionResult AddContact(Contacts contact)
        {
            Console.WriteLine($"Adding contact {contact}");
            return Ok($"Successfully added contact {contact}");
        }
        [HttpDelete("{id}")]
        //User Stories
        //CN001: Delete contact group
        public IActionResult DeleteContactGroup(int id)
        {
            Console.WriteLine($"Deleting contact group with ID {id}");
            return Ok($"Successfully deleted contact group with ID {id}");
        }
        [HttpDelete("{id}")]
        //User Stories
        //CN001: Delete Contact
        public IActionResult DeleteContact(int id)
        {
            Console.WriteLine($"Deleting contact with ID {id}");
            return Ok($"Successfully deleted contact with ID {id}");
        }
    }
}
