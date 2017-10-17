using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{

    /*
     What is LINQ ?
        - stands for : Langage Integrated Query
        - Gives us the capability to query objects in C# natively

        You can query :
            - Objects in memory, eg : collections (LINQ to Objects)
            - Databases (LINQ to Entities)
            - XML (LINQ to XML)
            - ADO.NET Data Sets (LINQ to Data Sets)

         */

    class Program
    {
        
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //LINQ Query Operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            /*---the same -----*/

            //LINQ Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            foreach(var bk in cheapBooks){
                // Console.WriteLine(book.Title);
                Console.WriteLine(bk);
            }


            /*------------------------------------------------------------------*/
            var book = books.Single(b => b.Title == "ASP.NET MVC"); //throw an exception if nothing found
            var book2 = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++"); //return null if nothing found

            Console.WriteLine(book.Title);
            Console.WriteLine(book2 == null ? "null" : book2.Title);

            /*-------------------------------------------------------------------*/

            var book3 = books.First(); //first element of the collection
            var book4 = books.First(b => b.Title == "C# Advanced Topics"); //first element of the collection
            var book5 = books.FirstOrDefault(); //return null if nothing found 

            Console.WriteLine(book3.Title);
            Console.WriteLine(book4.Price);
            Console.WriteLine(book5 == null ? "null" : book5.Title);

            var book6 = books.Last(); //first element of the collection
            var book7 = books.Last(b => b.Title == "C# Advanced Topics"); //first element of the collection
            var book8 = books.LastOrDefault(); //return null if nothing found 

            Console.WriteLine(book6.Title);
            Console.WriteLine(book7.Price);
            Console.WriteLine(book8 == null ? "null" : book8.Title);

            /*-------------------------------------------------------------------*/

            var books9 = books.Skip(2).Take(3); //used for paging data
            //skip 2 records or two objects and take 3
            foreach(var bb in books9)
            {
                Console.WriteLine(bb.Title);
            }


            /* --------------------------------------------------------------------*/

            var count = books.Count();
            Console.WriteLine(count);

            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            var sumPriceofAllBook = books.Sum(b => b.Price);
            var average = books.Average(b => b.Price);

            Console.WriteLine("maxPrice : {0} and min price : {1} and sum of all books : {2}, and finally average = {3}", maxPrice, minPrice, sumPriceofAllBook, average);

            Console.ReadLine();

        }
    }
}
