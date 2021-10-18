using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;
using CognitiveCoreUCU;
using System.Drawing;

namespace CompAndDel
{
    class Program
    {
        private static (IPicture, bool) HasFace(IPicture picture)
        {
            CognitiveFace cog = new CognitiveFace(true, Color.Green);
            cog.Recognize(path);
            return cog.FaceFound;
        }

        static void Main(string[] args)
        {
            IPipe initialPipe = new PipeSerial(
                new FilterGreyscale(),
                new PipeSerial(
                    new FilterSave(@"new_beer_1.jpg"),
                    new PipeConditionalFork(
                        new FilterConditional()
                    )
                )
            );

            PictureProvider provider = new PictureProvider();

            IPicture initialPicture = provider.GetPicture(@"beer.jpg");

            IPicture resultPicture = initialPipe.Send(initialPicture);
        }
    }
}
