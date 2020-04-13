using System;
using System.Collections.Generic;
using System.Text;

namespace pic
{
    class SwipeViewModel
    {
        static SwipeViewModel()
        {
            trueMatch = 0;
            falseMatch = 0;
            count = 0;
            carntotal = 0;
            herbtotal = 0;
            omnitotal = 0;
            largetotal = 0;
            smalltotal = 0;
            medtotal = 0;

            Pics = new List<PicObj>();

            Pics.Add(new PicObj("pic1","dino.jpg","carn","large"));
            Pics.Add(new PicObj("pic2", "dino2.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic3", "dino3.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic4", "dino4.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic5", "dino5.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic6", "dino6.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic7", "dino7.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic8", "dino8.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic9", "dino9.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic10", "dino10.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic11", "dino11.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic12", "dino12.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic13", "dino13.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic14", "dino14.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic15", "dino15.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic16", "dino16.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic17", "dino17.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic18", "dino18.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic19", "dino19.jpg", "carn", "large"));
            Pics.Add(new PicObj("pic20", "dino20.jpg", "carn", "large"));
        }

        public static IList<PicObj> Pics { private set; get; }
        public static int trueMatch { get; set; }
        public static int falseMatch { get; set; }
        public static int count { get; set; }
        public static int carntotal { get; set; }
        public static int herbtotal { get; set; }
        public static int omnitotal { get; set; }
        public static int largetotal { get; set; }
        public static int smalltotal { get; set; }
        public static int medtotal { get; set; }
    }
}
