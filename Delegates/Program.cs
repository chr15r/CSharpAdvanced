using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();

            var photoFilters = new PhotoFilters();

            // Custom delegate
            //PhotoProcessor.PhotoFilterHandler filterHandler = photoFilters.ApplyBrightness; 

            Action<Photo> filterHandler = photoFilters.ApplyBrightness;


            filterHandler += photoFilters.Resize;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("Test path", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            System.Console.WriteLine("Remove redeye");
        }

    }

}
