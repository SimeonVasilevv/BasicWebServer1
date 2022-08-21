using BasicWebServer1.Server.HTTP;

namespace BasicWebServer1.Server.Responses
{
    public class BadRequestResponse : Response
    {
        public BadRequestResponse(StatusCode statusCode) 
            : base(StatusCode.BadRequest)
        {
        }
    }
}
