using System;
using System.Drawing;
using TwitterUCU;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que publica la imagen en Twitter.
    /// </remarks>
    public class FilterTweet : IFilter
    {
        public string Path { get; }
        public string TweetStr { get; }

        public FilterTweet(string path, string tweetStr)
        {
            this.Path = path;
            this.TweetStr = tweetStr;
        }

        public IPicture Filter(IPicture image)
        {
            Utils.SaveImage(image, this.Path);

            TwitterImage twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter(this.TweetStr, this.Path));
            return image;
        }
    }
}