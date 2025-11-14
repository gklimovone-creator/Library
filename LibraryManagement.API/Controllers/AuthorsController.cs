using LibraryManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private static readonly List<Author> _authors = new();

        // GET: api/authors
        [HttpGet]
        public IActionResult GetAllAuthors()
        {
            return Ok(_authors);
        }

        [HttpPost]
        public IActionResult CreateAuthor([FromBody] Author author)
        {
            if (author == null)
            {
                return BadRequest("Author data is required");
            }

            // Логируем что пришло
            Console.WriteLine($"Received author: {System.Text.Json.JsonSerializer.Serialize(author)}");

            author.Author_id = _authors.Count + 1;
            _authors.Add(author);

            // Логируем что сохранили
            Console.WriteLine($"Saved authors count: {_authors.Count}");
            foreach (var a in _authors)
            {
                Console.WriteLine($"  - {a.Author_id}: {a.Full_name}, {a.Country}, {a.Email}");
            }

            return Ok(new
            {
                message = "Author created successfully",
                author = author
            });
        }

        [HttpDelete("clear")]
        public IActionResult ClearAllAuthors()
        {
            _authors.Clear();
            return Ok("All authors cleared");
        }

        [HttpGet("debug")]
        public IActionResult GetDebugInfo()
        {
            var debugInfo = new
            {
                AuthorsCount = _authors.Count,
                FirstAuthor = _authors.FirstOrDefault(),
                Encoding = System.Text.Encoding.Default.EncodingName,
                AllAuthors = _authors
            };
            return Ok(debugInfo);
        }
    }
}