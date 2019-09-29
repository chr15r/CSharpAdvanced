using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{


    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book
            {
                ISBN = "1234",
                Title = "Chris"
            };

            var numbers = new GenericList<int>();
            numbers.Add(1);

            var books = new GenericList<Book>();
            books.Add(book);

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", book);


            var number = new Nullable<int>();
            System.Console.WriteLine("Has value ? " + number.HasValue);
            System.Console.WriteLine("Value " + number.GetValueOrDefault());
        }
    }
}
