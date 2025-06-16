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
    [Authorize]
    internal class DocumentsController : ControllerBase
    {
        [HttpGet]
        //User Stories
        //DOC003: Get all documents and search/sort
        public IActionResult GetAllDocuments()
        {
            Console.WriteLine("Getting all documents");
            return Ok("Successfully retrieved all documents.");
        }
        [HttpGet("{id}")]
        public IActionResult GetDocumentById(int id)
        {
            Console.WriteLine($"Getting document with ID: {id}");
            return Ok($"Successfully retrieved document with ID: {id}.");
        }
        [HttpGet("{categoryId}")]
        //User Stories
        //DOC001: Get all documents under a certain category id
        public IActionResult GetDocumentsByCategoryId(int categoryId)
        {
            Console.WriteLine($"Getting documents for category with ID: {categoryId}");
            return Ok($"Successfully retrieved documents for category with ID: {categoryId}.");
        }
        [HttpPost]
        //User Stories
        //DOC001: Create Document
        public IActionResult CreateDocument(Documents document)
        {
            Console.WriteLine($"Creating document {document}");
            return Ok($"Successfully created document {document}.");
        }
        [HttpPut("{id}")]
        //User Stories
        //DOC001: Update Document
        //DOC002: Archive Document
        public IActionResult UpdateDocument(int id, Documents document)
        {
            Console.WriteLine($"Updating document with ID: {id}");
            return Ok($"Successfully updated document with ID: {id}.");
        }
        [HttpDelete("{id}")]
        //User Stories
        //DOC001: Delete Document
        public IActionResult DeleteDocument(int id)
        {
            Console.WriteLine($"Deleting document with ID: {id}");
            return Ok($"Successfully deleted document with ID: {id}.");
        }
    }
}
