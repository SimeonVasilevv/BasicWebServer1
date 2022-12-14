using System.Text;

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

        public StatusCode StatusCode { get; init; }

        public HeaderCollection Headers { get;} = new HeaderCollection();

        public string Body { get; set; }

        public Action<Request, Response> PreRenderAction { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"HTTP/1.1 {(int)this.StatusCode} {this.StatusCode}");

            foreach (var header in Headers)
            {
                result.AppendLine(header.ToString());
            }
            result.AppendLine();

            if (!string.IsNullOrEmpty(this.Body))
            {
                result.AppendLine(this.Body);
            }
            return result.ToString();
        }
    }
}
