using LibraryASPMVC.Data;
using LibraryASPMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryASPMVC.Services
{
    public class BookAuthorInfoService : Service
    {
        public BookAuthorInfoService(DB_LibraryContext context) : base(context) { }

        public async Task<List<BookAuthorInfo>> GetAllBooksAuthorInfo()
        {
            return await _context.BookAuthorInfos.ToListAsync();
        }

        public async Task<BookAuthorInfo?> GetBookAuthorInfoById(int id)
        {
            return await _context.BookAuthorInfos.FindAsync(id);
        }      

    }
}
