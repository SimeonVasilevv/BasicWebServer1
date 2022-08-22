using BasicWebServer1.Server.HTTP;

namespace BasicWebServer1.Server.Responses
{
    public class HtmlResponse : ContentResponse
    {
        public HtmlResponse(string text) 
            : base(text, ContentType.Html)
        {
        }
    }
}
