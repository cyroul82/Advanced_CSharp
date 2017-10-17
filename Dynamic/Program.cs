using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{

    /* 
     Programming Languages are divided into 2 types : 

        - Statically-Typed languages : C#, Java (static languages)
            Resolution of types, members, properties, methods is done at compile-time, get errors if not defined when compiled


        - Dynamically-Typed languages: Ruby, Javascript, Python (dynamic languages)
            Resolution of types, members, properties, methods is done at run-time


    
    
         */

    class Program
    {
        static void Main(string[] args)
        {
            dynamic name = "cyril";
            name = 10;
            /*------------*/
            dynamic a = 10;
            dynamic b = 5;
            var c = a+b;  //c is now dynamic
                          /*-------------*/

            int i = 5;
            dynamic d = i;

            long l = d; //don't need to cast

        }
    }
}
