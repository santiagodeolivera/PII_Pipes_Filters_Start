using System;

namespace CompAndDel
{
    public static class Utils
    {
        private static PictureProvider provider = new PictureProvider();
        public static void SaveImage(IPicture image, string path) =>
            provider.SavePicture(image, path);

        public static IPicture LoadImage(string path) =>
            provider.GetPicture(path);
    }
}
