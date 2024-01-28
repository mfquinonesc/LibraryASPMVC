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
        public IActionResult New()
        {
            return View();
        }

        public async Task<IActionResult> Create(Author author)
        {
            await this._service.CreateAuthor(author);
            return RedirectToAction("New");        
        }
    }
}
