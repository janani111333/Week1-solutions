namespace UtilLib
{
    public class UrlHostNameParser
    {
        public string ParseHostName(string url)
        {
            if (string.IsNullOrEmpty(url))
                return "Invalid URL";

            if (url.StartsWith("http://"))
                return url.Replace("http://", "").Split('/')[0];
            else if (url.StartsWith("https://"))
                return url.Replace("https://", "").Split('/')[0];
            else
                return "Unknown format";
        }
    }
}
