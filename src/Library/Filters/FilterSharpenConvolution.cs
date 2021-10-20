using System;
using System.Drawing;
using CompAndDel;

namespace CompAndDel.Filters
{
    public class FilterSharpenConvolution : FilterConvolution
    {
        public FilterSharpenConvolution(): base(
            (
                ( 0, -1,  0),
                (-1,  5, -1),
                ( 0, -1,  0)
            ), 0, 1
        ) {}
    }
}