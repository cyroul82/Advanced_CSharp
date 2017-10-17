using System;
using System.Linq;

namespace ExtensionMethods
{
    /*Careful to the namespace ...!!!*/

    // 1 - Create a static class (to follow conventions)
    public static class StringExtensions
    {
        // 2- Write Extension methods always static, 
        // first argument should always be "this" + the type we're extending + the name

        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords should => 0");

            if(numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "...";

        }
    }
    
}
