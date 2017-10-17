using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        // 1 - declare the delegate
        public delegate void PhotoFilterHandler(Photo photo);
        
        
        // 2, Give an delegate as argument to the method
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            // 3 - Pass the photo to the filter
            // it means that this code doesn't know any longer what filter will be applied
            // it is now the responsability of the client of this code
            
            filterHandler(photo);


            /* ------------- code before delegate ----------*/
            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);

            photo.Save();
        }

        //We can create delegate using default delegate with Action and Func (Action does not return anything as Func does)
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
