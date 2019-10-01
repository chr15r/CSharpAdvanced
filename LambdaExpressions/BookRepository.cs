using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>

                {
                    new Book() { Title = "Book 1", Price = 5 },
                    new Book() { Title = "Book 2", Price = 7 },
                    new Book() { Title = "Book 3", Price = 13 }
                };

        }

    }
}

