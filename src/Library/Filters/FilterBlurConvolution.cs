using System;
using System.Drawing;
using CompAndDel;

namespace CompAndDel.Filters
{
    public class FilterBlurConvolution : FilterConvolution
    {
        public FilterBlurConvolution(): base(
            (
                (1, 1, 1),
                (1, 1, 1),
                (1, 1, 1)
            ), 0, 9
        ) {}
    }
}