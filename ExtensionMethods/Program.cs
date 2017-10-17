using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    /**
     * What are Extension Methods ?
     *  Allow us to add methods to an existing class without 
     *      - changing its source code, or
     *      - creating a new class that inherits from it
     * */
    class Program
    {
        static void Main(string[] args)
        {
            string post = "this is suppose very long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>() { 1, 5, 10, 8, 54, 47 };
            var max = numbers.Max();

            Console.WriteLine(max);

            Console.WriteLine(shortenedPost);
            Console.ReadLine();
        }
    }
    
}
