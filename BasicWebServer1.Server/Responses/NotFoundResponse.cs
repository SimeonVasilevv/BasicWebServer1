using BasicWebServer1.Server.HTTP;

namespace BasicWebServer1.Server.Responses
{
    public class NotFoundResponse : Response
    {
        public NotFoundResponse(StatusCode statusCode) 
            : base(StatusCode.NotFound)
        {
        }
    }
}
