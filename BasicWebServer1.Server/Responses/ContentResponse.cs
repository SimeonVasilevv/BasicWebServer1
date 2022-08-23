﻿using BasicWebServer1.Server.Common;
using BasicWebServer1.Server.HTTP;
using System.Text;

namespace BasicWebServer1.Server.Responses
{
    public class ContentResponse : Response
    {
        public ContentResponse(string content, string contentType,
            Action<Request,Response> preRenderAction = null) 
            : base(StatusCode.OK)
        {
            Guard.AgainstNull(content);
            Guard.AgainstNull(contentType);

            this.Headers.Add(Header.ContentType, contentType);
            this.Body = content;
            this.PreRenderAction = preRenderAction;
        }

        public override string ToString()
        {
            if (this.Body != null)
            {
                var contentLength = Encoding.UTF8.GetByteCount(this.Body).ToString();
                this.Headers.Add(Header.ContentLength, contentLength);
            }

            return base.ToString();
        }
    }
}
