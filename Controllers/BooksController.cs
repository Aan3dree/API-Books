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

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            _bookService.AddBook(book);
            return Ok();
        }

    }
}