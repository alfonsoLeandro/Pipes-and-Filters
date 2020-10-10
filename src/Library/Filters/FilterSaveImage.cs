using System;
using System.Collections.Generic;
using System.Text;
using CompAndDel;
using System.Drawing;
using System.Diagnostics;

namespace CompAndDel.Filters
{
    public class FilterSaveImage : IFilter
    {
        public IPicture Filter(IPicture image)
        {
            Persist(image,"imagenintermedia.jpg");
            return image;
        }
        private void Persist(IPicture image, string pathToPersist)
        {
            PictureProvider provider = new PictureProvider();
            provider.SavePicture(image,pathToPersist);
        }
        }
    }