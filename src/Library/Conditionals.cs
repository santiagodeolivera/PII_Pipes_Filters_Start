using System;
using CognitiveCoreUCU;
using System.Drawing;

namespace CompAndDel
{
    public static class Conditionals
    {
        public static bool HasFace(IPicture image)
        {
            Utils.SaveImage(image, "tmpImage.jpg");
            CognitiveFace cog = new CognitiveFace(true, Color.Green);
            cog.Recognize("tmpImage.jpg");
            return cog.FaceFound;
        }
    }
}
