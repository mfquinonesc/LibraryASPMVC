﻿using LibraryASPMVC.Data;
using LibraryASPMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryASPMVC.Services
{
    public class BookService:Service
    {
        public BookService(DB_LibraryContext context) : base(context) { }

        //Get all the books 
        public async Task<List<Book>> GetAllBooks()
        {
            return await _context.Books.ToListAsync();
        }

        //Get book by Id
        public async Task<Book?> GetBookById(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        //Delete book by Id
        public async Task<Book?> DeleteBookById(int id)
        {
            var fbook = await _context.Books.FindAsync(id);
            if (fbook != null)
            {
                _context.Books.Remove(fbook);
                await _context.SaveChangesAsync();
            }
            return fbook;
        }

        //Update book by Id
        public async Task<Book?> UpdateBookById(int id, Book book)
        {
            var fbook = await _context.Books.FindAsync(id);
            if (fbook != null)
            {
                fbook.Id = id;
                fbook.Title = book.Title;
                fbook.AuthorId = book.AuthorId;
                _context.Books.Update(fbook);
                await _context.SaveChangesAsync();
            }
            return fbook;
        }

        //Create a new book
        public async Task<Book> CreateBook(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return book;
        }

        //Create a new book with the author Id
        public async Task<Book> CreateBook(Book book, int authorId)
        {
            var author = await _context.Authors.FindAsync(authorId);
            if (author != null)
            {
                await _context.Books.AddAsync(book);
                await _context.SaveChangesAsync();                
            }
            return book;
        }
    }
}
