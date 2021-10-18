using System;
using CompAndDel;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            IPipe endPipe = new PipeNull();
            IPipe initialPipe = new PipeSerial(
                new FilterGreyscale(),
                new PipeSerial(
                    new FilterSave(@"new_beer_1.jpg"),
                    new PipeConditionalFork(
                        new Condition(Conditionals.HasFace),
                        new PipeSerial(
                            new FilterLoad(@"tmpFace.jpg"),
                            new PipeSerial(
                                new FilterTweet(@"tmpFace.jpg", "Image tweeted!"),
                                endPipe
                            )
                        ),
                        new PipeSerial(
                            new FilterNegative(),
                            new PipeSerial(
                                new FilterSave(@"new_beer_2.jpg"),
                                endPipe
                            )
                        )
                    )
                )
            );

            IPicture initialPicture = Utils.LoadImage(@"luke.jpg");

            IPicture resultPicture = initialPipe.Send(initialPicture);
        }
    }
}
