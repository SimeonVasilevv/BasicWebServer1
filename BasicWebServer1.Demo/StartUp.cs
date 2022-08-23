using BasicWebServer1.Server;
using BasicWebServer1.Server.Responses;

public class StartUp
{
    public static void Main()
        => new HttpServer(routes => routes
        .MapGet("/", new TextResponse("Hello from the server!"))
        .MapGet("/HTML", new HtmlResponse("<h1>HTML response</h1>"))
        .MapGet("/Redirect", new RedirectResponse("https://softuni.bg")))
        .Start();
}