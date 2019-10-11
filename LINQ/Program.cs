using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ extension methods
            var pagedBooks = books.Skip(2).Take(3);
            foreach (var p in pagedBooks)
            {
                Console.WriteLine(p.Title);
            }

            Console.ReadLine();
        }

        public void Exercise1()
        {
            var books = new BookRepository().GetBooks();

            //LINQ Query operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;


            // LINQ extension methods
            var cheapBooks = books.Where(x => x.Price < 10)
                                         .OrderBy(b => b.Title)
                                         .Select(b => b.Title);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
            }

            Console.ReadLine();
        }

    }
}
