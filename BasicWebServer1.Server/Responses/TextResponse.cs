using BasicWebServer1.Server.HTTP;

namespace BasicWebServer1.Server.Responses
{
    public class TextResponse : ContentResponse
    {
        public TextResponse(string text,
            Action<Request,Response> preRenderAction = null) 
            : base(text,ContentType.PlainText,preRenderAction)
        {
        }
    }
}
