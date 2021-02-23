using BMVE.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core
{
    public partial class Runnable
    {
        protected void WebServer_Start(string domain, ushort port) => WebServerProxy.WebServer_Start(domain, port);

        protected void WebServer_NextRequest() => WebServerProxy.WebServer_GetNextRequest();

        protected string WebServer_GetRequestUrl() => WebServerProxy.WebServer_GetRequestUrl();

        protected string WebServer_GetRequestFullUrl() => WebServerProxy.WebServer_GetRequestFullUrl();

        protected string WebServer_GetRequestMethod() => WebServerProxy.WebServer_GetRequestMethod();

        protected string WebServer_GetRequestUserAgent() => WebServerProxy.WebServer_GetRequestUserAgent();

        protected string WebServer_GetRequestContentType() => WebServerProxy.WebServer_GetRequestContentType();

        protected string[] WebServer_GetRequestQueryStringKeys() => WebServerProxy.WebServer_GetRequestQueryStringKeys();

        protected string WebServer_GetRequestQueryStringValue(string key) => WebServerProxy.WebServer_GetRequestQueryStringValue(key);

        protected string[] WebServer_GetRequestFormDataKeys() => WebServerProxy.WebServer_GetRequestFormDataKeys();

        protected string WebServer_GetRequestFormDataValue(string key) => WebServerProxy.WebServer_GetRequestFormDataValue(key);

        protected string WebServer_ReadRequestBody() => WebServerProxy.WebServer_ReadRequestBody();

        protected void WebServer_Write(string text) => WebServerProxy.WebServer_Write(text);

        protected void WebServer_WriteLine(string text) => WebServerProxy.WebServer_WriteLine(text);

        protected void WebServer_SendResponse() => WebServerProxy.WebServer_SendResponse();

        protected void WebServer_SendResponse(string text) => WebServerProxy.WebServer_SendResponse(text);

        protected void WebServer_SendResponse(byte[] bytes) => WebServerProxy.WebServer_SendResponse(bytes);

        protected void WebServer_SetResponseContentType(string contentType) => WebServerProxy.WebServer_SetResponseContentType(contentType);

        protected string WebServer_GetResponseContentType() => WebServerProxy.WebServer_GetRequestContentType();

        protected void WebServer_SetResponseStatusCode(ushort statusCode) => WebServerProxy.WebServer_SetResponseStatusCode(statusCode);

        protected ushort WebServer_GetResponseStatusCode() => WebServerProxy.WebServer_GetResponseStatusCode();

        protected string WebServer_UrlEncode(string value) => WebServerProxy.WebServer_UrlEncode(value);

        protected string WebServer_UrlDecode(string rawString) => WebServerProxy.WebServer_UrlDecode(rawString);
    }
}
