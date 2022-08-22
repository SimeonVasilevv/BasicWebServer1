namespace BasicWebServer1.Server.HTTP
{
    public class Response
    {
        public Response(StatusCode statusCode)
        {
            StatusCode = statusCode;

            Headers.Add(Header.Server, "My Web Server");
            Headers.Add(Header.Date, $"{DateTime.UtcNow:r}");
        }

        public StatusCode StatusCode { get; set; }

        public HeaderCollection Headers { get;} = new HeaderCollection();

        public string Body { get; set; }
    }
}
