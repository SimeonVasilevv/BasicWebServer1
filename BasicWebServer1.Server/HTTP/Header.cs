namespace BasicWebServer1.Server.HTTP
{
    public class Header
    {
        public Header(string name,string value)
        {
            Name = name;
            Value = value;
        }
        public string Name { get; init; }
        public string Value { get; set; }

    }
}
