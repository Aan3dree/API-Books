using Microsoft.AspNetCore.Mvc;
using BooksApi.Services;
using BooksApi.ViewModels;

namespace BooksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController: ControllerBase
    {
        public BooksService _bookService;
        public BooksController(BooksService booksService)
        {
            _bookService = booksService;
        }

        [HttpGet("get-all-books")]
        public IActionResult GetAllBooks()
        {
            var allBooks = _bookService.GetAllBooks();
            return Ok(allBooks);
        }

        [HttpGet("get-book/{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _bookService.GetBookById(id);
            return Ok(book);
        }

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            _bookService.AddBook(book);
            return Ok();
        }

        [HttpPut("update-book/{id}")]
        public IActionResult UpdateBook(int id, [FromBody]BookVM book){
            var updatedBook = _bookService.UpdateBook(id, book);
            return Ok(book);
        }
    }
}