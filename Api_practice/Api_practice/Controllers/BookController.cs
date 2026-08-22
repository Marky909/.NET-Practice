using Microsoft.AspNetCore.Mvc;
using FirstAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace FirstAPI.Controllers
{
    // Route resolves to: api/books [2]
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // In-memory static list populated with sample books [2, 6]
        private static readonly List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", YearPublished = 1960 },
            new Book { Id = 3, Title = "1984", Author = "George Orwell", YearPublished = 1949 },
            new Book { Id = 4, Title = "The Catcher in the Rye", Author = "J.D. Salinger", YearPublished = 1951 },
            new Book { Id = 5, Title = "Moby Dick", Author = "Herman Melville", YearPublished = 1851 }
        };

        // 1. GET: api/books (Retrieve all books) [7]
        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            // Returns the list wrapped inside a 200 OK status code [7, 8]
            return Ok(books);
        }

        // 2. GET: api/books/{id} (Retrieve a single book by ID) [9]
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);

            // If the book does not exist, return a 404 Not Found response [10]
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        // 3. POST: api/books (Create a new book) [11]
        [HttpPost]
        public ActionResult<Book> AddBook([FromBody] Book newBook)
        {
            if (newBook == null)
            {
                return BadRequest(); // Returns 400 Bad Request [11]
            }

            books.Add(newBook); // Appends to in-memory collection [12]

            // Returns a 201 Created status, a header containing the URL to fetch the new book, 
            // and the newly created book object in the response body [12]
            return CreatedAtAction(nameof(GetBook), new { id = newBook.Id }, newBook);
        }

        // 4. PUT: api/books/{id} (Update an entire book) [13, 14]
        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] Book updatedBook)
        {
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound(); // Returns 404 if the book doesn't exist
            }

            // Update individual properties of the matched record [14, 15]
            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.YearPublished = updatedBook.YearPublished;

            // Returns a 204 No Content status code indicating a successful update with no returned body [15]
            return NoContent();
        }

        // 5. DELETE: api/books/{id} (Delete a book) [16, 17]
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound(); // Returns 404 if the book isn't found [17]
            }

            books.Remove(book); // Removes from the list [17]

            return NoContent(); // Returns 204 No Content on success [17]
        }
    }
}