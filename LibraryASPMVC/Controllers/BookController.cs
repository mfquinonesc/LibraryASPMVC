using LibraryASPMVC.Models;
using LibraryASPMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryASPMVC.Controllers
{
    public class BookController : Controller
    {

        private readonly BookService _service;
        private readonly AuthorService _authorService;

        public BookController(BookService service, AuthorService authorService)
        {
            _service = service;
            _authorService = authorService;
        }

        public async Task<IActionResult> New()
        {
            var result = await _authorService.GetAllAuthors();
            return View(result);
        }

        public async Task<IActionResult> Create(Book book)
        {
            int id = book.AuthorId ?? 0;
            var result = await this._service.CreateBook(book, id);
            return RedirectToAction("Index","Home");
        }

    }
}
