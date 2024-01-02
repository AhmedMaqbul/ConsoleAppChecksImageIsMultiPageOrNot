using ImageMagick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChecksImageIsMultiPageOrNot
{
    public class Program
    {
        static void Main(string[] args)
        {

            string imagePath = "C:\\Users\\maqbul.ahmed\\Pictures\\Combined_Document 3.tiff";

            try
            {
                using (MagickImageCollection collection = new MagickImageCollection(imagePath))
                {
                    if (collection.Count > 1)
                    {
                        Console.WriteLine($"The image '{imagePath}' is multi-page, containing {collection.Count} pages.");
                    }
                    else
                    {
                        Console.WriteLine($"The image '{imagePath}' is a single-page image.");
                    }
                }
            }
            catch (MagickCorruptImageErrorException)
            {
                Console.WriteLine($"The image file '{imagePath}' is corrupt or not supported.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
