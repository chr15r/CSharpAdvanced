﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    partial class Program
    {
        static void Main(string[] args)
        {

            // NumbersExample();

            var books = new BookRepository().GetBooks();


            //var cheapBooks = books.FindAll(isCheaperThan10); ** Using the delegate option

            var cheapBooks = books.FindAll(b => b.Price < 10);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

        }

        static bool isCheaperThan10(Book book)
        {
            return book.Price < 10;
        }

        static void NumbersExample()
        {
            // args => expression
            //number => number * number;

            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));


            // () =>
            // x =>
            //(x, y, z) =>

            const int factor = 5;
            Func<int, int> multipler = n => n * factor;
            var result = multipler(10);
            Console.WriteLine(result);
        }
    }

}