using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomTwo.Data
{
    public class Post
    {
        private int PostID { get; set; }
        protected string Text { get; set; }
        public string ImageLink { get; set; }

        public virtual void WhatIsPost()
        {
            Console.WriteLine("It is a post.");
        }
    }




    public class VideoPost : Post
    {
        public string VideoLink { get; set; }

        public VideoPost()
        {
            Text = "dgfdhg";
        }
        
        public void PlayVideo()
        {

        }

        public override void WhatIsPost()
        {
            Console.WriteLine("This is video.");

            base.WhatIsPost();
        }
    }
}
