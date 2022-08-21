using BasicWebServer1.Server.HTTP;

namespace BasicWebServer1.Server.Responses
{
    public class UnauthorizedResponse : Response
    {
        public UnauthorizedResponse(StatusCode statusCode) 
            : base(StatusCode.Unauthorized)
        {
        }
    }
}
