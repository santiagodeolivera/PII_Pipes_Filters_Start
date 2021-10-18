using System;
using System.Drawing;
using TwitterUCU;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que recibe una imagen y retorna su negativo.
    /// </remarks>
    public class FilterTweet : IFilter
    {
        public string Path { get; }

        public FilterTweet(string path)
        {
            this.Path = path;
        }

        public IPicture Filter(IPicture image)
        {
            PictureProvider provider = new PictureProvider();
            provider.SavePicture(image, this.Path);

            TwitterImage twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("Image tweeted!", this.Path));
            return image;
        }
    }
}