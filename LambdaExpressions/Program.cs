using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 What is a Lambda Expression ?
    An anonymous method
        - No access modifier
        - No name
        - No return statement
  
 What do we use them ?
   For convenience less code and achieve the same thing and more readable
 */


namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstExample();

            SecondExample();

            Console.ReadLine();

        }

        static void FirstExample()
        {
            Console.WriteLine(Square(5));

            Func<int, int> square = Square; //Create a delegate that is pointing to the Square Method
            Console.WriteLine(square(5));

            //args => expression
            Func<int, int> square2 = number => number * number; //We can use a lambda expression, then the Square Method is not used any more
            Console.WriteLine(square2(5));

            // () => ... (no argument)
            // x => ... (1 argument)
            // (x, y, z) => ... (several arguments)


            /* another example */
            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;

            var result = multiplier(10);
            Console.WriteLine(result);

        }

        static int Square(int number)
        {
            return number * number;
        }

        static void SecondExample()
        {
            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(IsCheaperThan10Dolllars);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            /* What is a predicate ?
             *  - a predicate is basically a delegate which points to a method that gets a book(in this case)
             *  and returns a boolean value specifying if a given condition was satisfied
             */

            var cheapBooksLambdaExpression = books.FindAll(b => b.Price < 10);
            foreach (var b in cheapBooks)
            {
                Console.WriteLine(b.Title);
            }
        }

        //This is called a predicate method, it gets an object of type book and returns True if a given condition is satisfied
        static bool IsCheaperThan10Dolllars(Book book)
        {
            return book.Price < 10;
        }
    }
}
