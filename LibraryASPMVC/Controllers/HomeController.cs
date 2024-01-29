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
        
        //Display home page and send the list
        //of all the books with their authors 
        public async Task<IActionResult> Index()
        {
            ViewData["isEditable"] = false;
            var result = await this._service.GetAllBooksAuthorInfo();
            return View(result);
        }      
        

    }
}
