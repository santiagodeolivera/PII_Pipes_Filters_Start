using System;
using CompAndDel;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que carga una imagen del sistema de archivos.
    /// </summary>
    public class FilterLoad : IFilter
    {
        public string Path { get; }

        public FilterLoad(string path)
        {
            this.Path = path;
        }

        public IPicture Filter(IPicture image) =>
            Utils.LoadImage(this.Path);
    }
}
