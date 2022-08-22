using BasicWebServer1.Server.Common;
using BasicWebServer1.Server.HTTP;

namespace BasicWebServer1.Server.Responses
{
    public class ContentResponse : Response
    {
        public ContentResponse(string content, string contentType) 
            : base(StatusCode.OK)
        {
            Guard.AgainstNull(content);
            Guard.AgainstNull(contentType);

            this.Headers.Add(Header.ContentType, contentType);
            this.Body = content;
        }
    }
}
