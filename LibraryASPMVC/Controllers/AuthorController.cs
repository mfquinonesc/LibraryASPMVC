using LibraryASPMVC.Models;
using LibraryASPMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryASPMVC.Controllers
{
    public class AuthorController : Controller
    {
        private readonly AuthorService _service;

        public AuthorController(AuthorService service)
        {
            this._service = service;
        }

        //Display new author view and send the list of all authors
        public async Task<IActionResult> New()
        {
            var result = await _service.GetAllAuthors();
            return View(result);
        }

        //Create new Author
        public async Task<IActionResult> Create(Author author)
        {
            await this._service.CreateAuthor(author);
            return RedirectToAction("New");
        }

        //Delete author by Id
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAuthorById(id);
            await _service.GetAllAuthors();
            return RedirectToAction("New");
        }
    }
}
