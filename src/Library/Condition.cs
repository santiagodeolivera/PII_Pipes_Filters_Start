using System;
using CompAndDel;

namespace CompAndDel.Filters
{
    public class Condition
    {
        private Func<IPicture, bool> predicate;

        public Condition(Func<IPicture, bool> predicate)
        {
            this.predicate = predicate;
        }

        public bool Filter(IPicture image) => (this.predicate)(image);
    }
}