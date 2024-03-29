using System;
using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que guarda una imagen en el sistema de archivos.
    /// </remarks>
    public class FilterSave : IFilter
    {
        public string Path { get; }

        public FilterSave(string path)
        {
            this.Path = path;
        }

        public IPicture Filter(IPicture image)
        {
            PictureProvider provider = new PictureProvider();
            provider.SavePicture(image, this.Path);
            return image;
        }
    }
}