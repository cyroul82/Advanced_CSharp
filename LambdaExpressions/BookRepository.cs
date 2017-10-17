using System.Collections.Generic;

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
    public class BookRepository {

        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title="Title 1", Price=5},
                new Book() {Title="Title 2", Price=7},
                new Book() {Title="Title 3", Price=17}
            };
        }
    }
}
