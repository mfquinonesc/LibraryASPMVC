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
        public async Task<IActionResult> New(int? id)
        {
            var resultTable = await _service.GetAllAuthors();
            AuthorBookModels models = new AuthorBookModels();
            models.Authors = resultTable;
            if (id != null)
            {
                int _id = id ?? 0;               
                var resultAuhtor = await _service.GetAuthorById(_id);               
                models.Author = resultAuhtor ?? new Author();               
                ViewData["isUpdate"] = true;                         
            }
            else
            {
                models.Author = new Author();
                ViewData["isUpdate"] = false;               
            }
            return View(models);
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
            return RedirectToAction("New");
        }

        //Update author by Id
        public async Task<IActionResult> Update(Author author,int id)
        {
            await this._service.UpdateAuthorById(id,author);           
            return RedirectToAction("New");
        }
    }
}
