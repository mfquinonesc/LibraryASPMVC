using LibraryASPMVC.Models;
using LibraryASPMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LibraryASPMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookAuthorInfoService _service;

        public HomeController(BookAuthorInfoService service)
        {
            this._service = service;
        }

        public async Task<IActionResult> Index()
        {
            var result = await this._service.GetAllBooksAuthorInfo();
            return View(result);
        }       
        public IActionResult Delete()
        {
            return NotFound();
        }

    }
}
