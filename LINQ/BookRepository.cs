using System.Collections.Generic;

namespace LINQ
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Book 1", Price = 5},
                new Book() {Title = "Book 1", Price = 9.99f},
                new Book() {Title = "Book 3", Price = 12},
                new Book() {Title = "Book 4", Price = 7},
                new Book() {Title = "Book 5", Price = 9}
            };
        }
    }
}
