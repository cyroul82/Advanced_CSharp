using System;

namespace Delegates
{

    /*
     What is a Delegate ? 
         a delegate is an object that knows how to call a method (or a group of methods)
         Basiclay is a reference or a pointer to a function

    Why do we need delegates ?
        For designing extensible and flexible applications(eg: frameworks)

    Alternatively we can use Interfaces !!!


    Interfaces or Delegates ? (Personal Preferences, but MSDN Guideline says as follow)
        Use a delegate when :
            - An eventing design pattern is used
            - The caller doesn't need to access other properties or methods on the object implementing the method
    */


    public class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += ApplySaturation;
            
            processor.Process("urlphoto", filterHandler);


            //the same but using default delegates
            Action<Photo> filterHandler2 = filters.ApplyContrast;
            processor.Process("urlphoto", filterHandler2);



            Console.ReadLine();
        }

        //We can now create our own filter without recompiling the code 
        static void ApplySaturation(Photo photo)
        {
            Console.WriteLine("Apply staturation");
        }
    }
}
