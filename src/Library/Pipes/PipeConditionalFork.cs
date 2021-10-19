using System;
using CompAndDel;
using CompAndDel.Filters;

namespace CompAndDel.Pipes
{
    public class PipeConditionalFork : IPipe
    {
        // It was decided to use the Condition class because the responsibility
        // of receiving a picture and returning a boolean value wasn't quite fitting of the IFilter interface
        // (which receives a picture and returns another picture).
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
