using System;

namespace AluraPic.Api.Controllers
{
    public class Photo
    {
        public int id { get; set; }
        public DateTime postDate { get; set; }
        public string url { get; set; }
        public bool allowComments { get; set; }
        public int likes { get; set; }
        public int comments { get; set; }
        public int userId { get; set; }

        public string description { get; set; }
    }
}
