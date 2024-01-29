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

       
        //Diaplay the Create a new Author view 
        //and send the list of all authors
        public async Task<IActionResult> New()
        {
            var result = await _authorService.GetAllAuthors();
            return View(result);
        }

        
        //Create new Book and return to Home
        public async Task<IActionResult> Create(Book book)
        {
            int id = book.AuthorId ?? 0;
            await this._service.CreateBook(book, id);
            return RedirectToAction("Index","Home");
        }

        //Delete book by Id and return to Home
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteBookById(id);
            return RedirectToAction("Index", "Home");
        }

    }
}
