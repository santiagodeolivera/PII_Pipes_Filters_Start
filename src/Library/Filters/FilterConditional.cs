using System;
using CompAndDel;

namespace CompAndDel.Filters
{
    public class FilterConditional : IFilter
    {
        private bool result;
        public bool ReturnsTrue => this.result;

        private Func<IPicture, (IPicture, bool)> predicate;

        public FilterConditional(Func<IPicture, (IPicture, bool)> predicate)
        {
            this.predicate = predicate;
        }

        public IPicture Filter(IPicture image)
        {
            var (result, isTrue) = (this.predicate)(image);
            this.result = isTrue;
            return result;
        }
    }
}