using System;
using CompAndDel;
using CompAndDel.Filters;

namespace CompAndDel.Pipes
{
    public class PipeConditionalFork : IPipe
    {
        private FilterConditional filter { get; }
        private IPipe pipeTrue { get; }
        private IPipe pipeFalse { get; }

        public PipeConditionalFork(FilterConditional filter, IPipe pipeTrue, IPipe pipeFalse)
        {
            this.filter = filter;
            this.pipeTrue = pipeTrue;
            this.pipeFalse = pipeFalse;
        }

        public IPicture Send(IPicture picture)
        {
            picture = this.filter.Filter(picture);
            return this.filter.ReturnsTrue ? this.pipeTrue.Send(picture) : this.pipeFalse.Send(picture);
        }
    }
}