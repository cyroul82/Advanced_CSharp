using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    /*
     Value Types 
        - Cannot be null
        - bool hasAccess = true; //or false
         
         */
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime data = null  -> // give error value type cannot be null
            Nullable<DateTime> date = null;
            //same writing
            DateTime? date2 = null;

            Console.WriteLine("GetValueOrDefault : " + date.GetValueOrDefault());
            Console.WriteLine("HasValue : " + date.HasValue);
       //     Console.WriteLine("Value : " + date.Value);
            //make sure to have a value set, otherwise will get an invalid exception has the example above is throwing


            /*----------------------------------------------------------*/

            DateTime? d = new DateTime(2014, 1, 1);
            DateTime dd = d.GetValueOrDefault(); //if not set cannot compile or we can still set dd to nullable !!!

            Console.WriteLine(dd);


            /*------------------------------------------------------------*/

            //Null Coallition

            DateTime? dt = null;
            DateTime dt2;

            if (dt != null)
                dt2 = dt.GetValueOrDefault();
            else
                dt2 = DateTime.Today;

            //Using different syntaxe to get the same result as the if else statement

            dt2 = dt ?? DateTime.Today; //same as the if else statement called coalescing  

            DateTime dt3 = (dt != null) ? dt.GetValueOrDefault() : DateTime.Today; //

            Console.WriteLine(dt2);

            Console.ReadLine();
        }
    }
}
