using System;

namespace ShortUrlsWebApp
{
    public class ShortUrl
    {
        public string Url { get; set; }
        public string UrlEncoded { get; set; }
        public DateTime Created { get; set; }
    }
}
