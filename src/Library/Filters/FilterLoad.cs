using System;
using CompAndDel;

namespace CompAndDel.Filters
{
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
