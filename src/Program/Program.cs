using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider pictureProvider = new PictureProvider();

            IPicture firstPicture = pictureProvider.GetPicture("perro foto.jpg");

            IPicture resultPicture = new PipeSerial(new FilterGreyscale(), new PipeSerial( 
                new FilterSaveImage(),new PipeSerial( new FilterNegative(), new PipeNull()))
            ).Send(firstPicture);

            pictureProvider.SavePicture(resultPicture, "perro foto final.jpg");
        }
    }
}
