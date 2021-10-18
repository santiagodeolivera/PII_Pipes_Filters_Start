using System;
using CompAndDel;
using CompAndDel.Filters;

namespace CompAndDel.Pipes
{
    public class PipeConditionalFork : IPipe
    {
        private Condition filter { get; }
        private IPipe pipeTrue { get; }
        private IPipe pipeFalse { get; }

        public PipeConditionalFork(Condition filter, IPipe pipeTrue, IPipe pipeFalse)
        {
            this.filter = filter;
            this.pipeTrue = pipeTrue;
            this.pipeFalse = pipeFalse;
        }

        public IPicture Send(IPicture picture)
        {
            return this.filter.Filter(picture) ? this.pipeTrue.Send(picture) : this.pipeFalse.Send(picture);
        }
    }
}