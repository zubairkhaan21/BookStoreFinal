using BookStoreFinal.Data;
using BookStoreFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreFinal.Repository
{
    public class BookRepository
    {
        private readonly BookStoreContext _context = null;
        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public int AddNewBook(BookModel model) {
            var newBook = new Books()
            {
                Author = model.Author,
                Title = model.Title,
                Description = model.Description,
                TotalPages = model.TotalPages
            };

            _context.Books.Add(newBook);
            _context.SaveChanges();
            return newBook.Id;
        }
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        public List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Author = "Muhammad Zubair", Title = "PHP", Description = "This is Book 1 Description",Language = "English",TotalPages = 100, Category = "Science"},
                new BookModel() { Id = 2, Author = "Muhammad ", Title = "PHP 1",Description = "This is Book 2 Description",Language = "English",TotalPages = 100, Category = "Science"},
                new BookModel() { Id = 3, Author = "Muhammad ", Title = "PHP 2",Description = "This is Book 3 Description",Language = "English",TotalPages = 100, Category = "Science"},
                new BookModel() { Id = 4, Author = "Muhammad ", Title = "PHP 3",Description = "This is Book 4 Description",Language = "English",TotalPages = 100, Category = "Science"},
                new BookModel() { Id = 5, Author = "Muhammad ", Title = "PHP 4",Description = "This is Book 5 Description",Language = "English",TotalPages = 100, Category = "Science"},

            };
        }

    }
}
