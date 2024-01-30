using LibraryASPMVC.Models;
using LibraryASPMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryASPMVC.Controllers
{
    public class BookController : Controller
    {

        private readonly BookService _service;
        private readonly AuthorService _authorService;
        private readonly BookAuthorInfoService _bookAuthorInfoService;
        

        public BookController(BookService service, AuthorService authorService,BookAuthorInfoService bookAuthorInfoService)
        {
            _service = service;
            _authorService = authorService;
            _bookAuthorInfoService = bookAuthorInfoService;
        }

       
        //Diaplay the Create a new Author view 
        //and send the list of all authors
        public async Task<IActionResult> New (int? id)
        {
            var resultInfos = await _bookAuthorInfoService.GetAllBooksAuthorInfo();
            var resultAuhtors = await _authorService.GetAllAuthors();
            AuthorBookModels models = new AuthorBookModels();
            models.Authors = resultAuhtors;
            models.BookAuthorInfos = resultInfos;
            ViewData["isEditable"] = true;

            if (id != null)
            {
                int _id = id ?? 0;
                ViewData["isUpdate"] = true;
                var resultBook = await _service.GetBookById(_id);
                models.Book = resultBook ?? new Book();               
            }
            else
            {                            
                ViewData["isUpdate"] = false;               
            }
            return View(models);
        }

        
        //Create new Book and return to New Book
        public async Task<IActionResult> Create(Book book)
        {
            int id = book.AuthorId ?? 0;
            await this._service.CreateBook(book, id);
            return RedirectToAction("New", "Book");
        }

        //Delete book by Id and return to New Book
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteBookById(id);
            return RedirectToAction("New", "Book");
        }

        //Update book by Id and return to New Book
        public async Task<IActionResult> Update(int id, Book book)
        {
            await _service.UpdateBookById(id, book);
            return RedirectToAction("New", "Book");
        }

    }
}
