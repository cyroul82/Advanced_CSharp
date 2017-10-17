
using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics
{

    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(10);  //Add takes an int

            var books = new GenericList<Book>();
            books.Add(new Book()); //Add take a book

            var account = new GenericDictionnary<int, string>();

            /*---------------------------------*/
            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value ?: " + number.HasValue);
            Console.WriteLine("Value : " + number.GetValueOrDefault());


            var num = new Nullable<int>();
            Console.WriteLine("Has Value ?: " + num.HasValue);
            Console.WriteLine("Value : " + num.GetValueOrDefault());

            Console.ReadLine();

            //Nullable is part of the .Net

        }
    }
}
