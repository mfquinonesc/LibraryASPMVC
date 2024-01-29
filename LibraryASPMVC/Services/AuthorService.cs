using LibraryASPMVC.Data;
using LibraryASPMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryASPMVC.Services
{
    public class AuthorService : Service
    {
        public AuthorService(DB_LibraryContext context) : base(context) { }

        //Get All Auhtors
        public async Task<List<Author>> GetAllAuthors()
        {
            return await _context.Authors.ToListAsync();
        }

        //Get Author By Id
        public async Task<Author?> GetAuthorById(int id)
        {
            return await _context.Authors.FindAsync(id);
        }

        //Delete Author by Id
        public async Task<Author?> DeleteAuthorById(int id)
        {
            var fauthor = await _context.Authors.FindAsync(id);
            if (fauthor != null)
            {
                _context.Authors.Remove(fauthor);
                await _context.SaveChangesAsync();
            }
            return fauthor;
        }

        //Update Author by Id
        public async Task<Author?> UpdateAuthorById(int id, Author author)
        {
            var fauthor = await _context.Authors.FindAsync(id);
            if (fauthor != null)
            {
                fauthor.AuthorId = id;
                fauthor.Name = author.Name;
                _context.Authors.Update(fauthor);
                await _context.SaveChangesAsync();
            }
            return fauthor;
        }

        // Create a new Author
        public async Task<Author> CreateAuthor(Author author)
        {
            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();
            return author;
        }
    }
}
