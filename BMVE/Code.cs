using BMVE.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE
{
    class Code : Runnable
    {
        public override void Main()
        {
            WebServer_Start("localhost", 10098);

            while (true)
            {
                WebServer_NextRequest();

                string url = WebServer_GetRequestUrl();
                string fullUrl = WebServer_GetRequestFullUrl();
                string requestBody = WebServer_ReadRequestBody();
                string method = WebServer_GetRequestMethod();
                string userAgent = WebServer_GetRequestUserAgent();
                string[] keys = WebServer_GetRequestQueryStringKeys();
                string[] formDataKeys = WebServer_GetRequestFormDataKeys();

                if (url == "/cc")
                {
                    WebServer_SetResponseContentType("image/png");
                    File_OpenToRead(1, "F:\\IOBM-short.png");
                    byte[] bytes = File_ReadBytes(1, (int)File_GetSize("f:\\IOBM-short.png"));
                    File_Close(1);

                    WebServer_SendResponse(bytes);
                }
                else if (url == "/fd")
                {
                    WebServer_WriteLine(@"<html><body></body><form action=""mimimi"" method=""POST""><input type=""text"" name=""wat"" /><input type=""text"" name=""wuf"" /><input type=""submit"" /></form></html>");
                    WebServer_SendResponse();

                }
                else
                {
                    WebServer_WriteLine("Url:" + url);
                    WebServer_WriteLine("Full url:" + fullUrl);
                    WebServer_WriteLine("Body:" + requestBody);
                    WebServer_WriteLine("Method:" + method);
                    WebServer_WriteLine("UserAgent:" + userAgent);

                    WebServer_WriteLine("Query string keys:");
                    foreach (var key in keys)
                    {
                        string value = WebServer_GetRequestQueryStringValue(key);
                        WebServer_WriteLine($"Key {key} = {value}");
                    }
                    WebServer_WriteLine("Form Data keys:");
                    foreach (var key in formDataKeys)
                    {
                        string value = WebServer_GetRequestFormDataValue(key);
                        WebServer_WriteLine($"Key {key} = {value}");
                    }
                    WebServer_SendResponse();
                }
            }
        }
    }
}
