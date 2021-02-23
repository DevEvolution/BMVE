using BMVE.Core.Utils.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class WebServerProxy
    {
        private static WebServer _webServer;
        private static StringBuilder _responseStringBuilder;

        internal static void WebServer_Start(string domain, ushort port)
        {
            _webServer = new WebServer(domain, port);
        }

        internal static void WebServer_GetNextRequest()
        {
            CheckWebServerStatus();

            _webServer.ProcessRequest();
            _responseStringBuilder = new StringBuilder();
        }

        internal static string WebServer_GetRequestUrl()
        {
            CheckWebServerStatus();

            var url = _webServer.request.RawUrl;
            var queryStringPosition = url.IndexOf('?');
            if (queryStringPosition > -1)
            {
                url = url.Substring(0, queryStringPosition);
            }    

            return url;
        }

        internal static string WebServer_GetRequestUserAgent()
        {
            CheckWebServerStatus();

            return _webServer.request.UserAgent;
        }

        internal static string WebServer_GetRequestMethod()
        {
            CheckWebServerStatus();

            return _webServer.request.HttpMethod;
        }

        internal static string WebServer_GetRequestContentType()
        {
            CheckWebServerStatus();

            return _webServer.request.ContentType;
        }

        internal static string WebServer_GetRequestFullUrl()
        {
            CheckWebServerStatus();

            return _webServer.request.Url.AbsoluteUri;
        }

        internal static long WebServer_GetRequestContentLength()
        {
            CheckWebServerStatus();

            return _webServer.request.ContentLength64;
        }

        internal static string[] WebServer_GetRequestQueryStringKeys()
        {
            CheckWebServerStatus();

            return _webServer.request.QueryString.Keys.Cast<string>().Select(x => WebUtility.UrlDecode(x)).ToArray();
        }

        internal static string WebServer_GetRequestQueryStringValue(string key)
        {
            CheckWebServerStatus();

            if (!_webServer.request.QueryString.Keys.Cast<string>().Select(x => WebUtility.UrlDecode(x)).Contains(key))
            {
                throw new Exception($"Строка параметров не содержит параметр {key}");
            }

            return WebUtility.UrlDecode(_webServer.request.QueryString[key]);
        }

        internal static string WebServer_ReadRequestBody()
        {
            CheckWebServerStatus();

            using (var memStream = new MemoryStream())
            {
                _webServer.request.InputStream.CopyTo(memStream);
                memStream.Position = 0;
                using (var istream = new StreamReader(memStream))
                {
                    return istream.ReadToEnd();
                }
            }
        }

        internal static string[] WebServer_GetRequestFormDataKeys()
        {
            var formDataString = WebServer_ReadRequestBody();
            var keys = formDataString
                .Split('&')
                .Where(x => !string.IsNullOrEmpty(x))
                .ToDictionary(x => WebUtility.UrlDecode(x.Split('=').First()), x => WebUtility.UrlDecode(x.Split('=').Last()))
                .Keys;

            return keys.ToArray();
        }

        internal static string WebServer_GetRequestFormDataValue(string key)
        {
            var formDataString = WebServer_ReadRequestBody();
            var dictionary = formDataString
                .Split('&')
                .Where(x => !string.IsNullOrEmpty(x))
                .ToDictionary(x => WebUtility.UrlDecode(x.Split('=').First()), x => WebUtility.UrlDecode(x.Split('=').Last()));

            if (!dictionary.ContainsKey(key))
            {
                throw new Exception($"FormData не содержит параметр {key}");
            }

            return WebUtility.UrlDecode(dictionary[key]);
        }

        internal static void WebServer_Write(string text)
        {
            _responseStringBuilder = _responseStringBuilder.Append(text);
        }

        internal static void WebServer_WriteLine(string text)
        {
            _responseStringBuilder = _responseStringBuilder.AppendLine(text);
        }

        internal static void WebServer_SetResponseContentType(string contentType)
        {
            _webServer.response.ContentType = contentType;
        }

        internal static string WebServer_GetResponseContentType() => _webServer.response.ContentType;

        internal static void WebServer_SetResponseStatusCode(ushort statusCode) => _webServer.response.StatusCode = statusCode;

        internal static ushort WebServer_GetResponseStatusCode() => (ushort) _webServer.response.StatusCode;

        internal static void WebServer_SendResponse()
        {
            _webServer.SendResult(System.Text.Encoding.UTF8.GetBytes(_responseStringBuilder.ToString()));
        }

        internal static void WebServer_SendResponse(string text)
        {
            _responseStringBuilder = _responseStringBuilder.Append(text);
            _webServer.SendResult(System.Text.Encoding.UTF8.GetBytes(_responseStringBuilder.ToString()));
        }

        internal static void WebServer_SendResponse(byte[] bytes)
        {
            _webServer.SendResult(bytes);
        }

        internal static string WebServer_UrlEncode(string rawString)
        {
            return WebUtility.UrlEncode(rawString);
        }

        internal static string WebServer_UrlDecode(string rawString)
        {
            return WebUtility.UrlDecode(rawString);
        }

        private static void CheckWebServerStatus()
        {
            if (_webServer == null)
            {
                throw new Exception("Слушающий веб-сервер не запущен");
            }
        }
    }
}
