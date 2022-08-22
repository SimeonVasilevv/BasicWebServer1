using BasicWebServer1.Server.Common;

namespace BasicWebServer1.Server.HTTP
{
    public class Header
    {
        public const string ContentType = "Content-Type";
        public const string CintentLength = "Content-Length";
        public const string Date = "Date";
        public const string Location = "Location";
        public const string Server = "Server";

        public Header(string name,string value)
        {
            Guard.AgainstNull(name, nameof(name));
            Guard.AgainstNull(value, nameof(value));

            Name = name;
            Value = value;
        }
        public string Name { get; init; }
        public string Value { get; set; }

    }
}
