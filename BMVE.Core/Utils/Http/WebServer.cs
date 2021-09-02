using BMVE.Core.Utils.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Http
{
    internal class WebServer
    {
        private HttpListener _listener;
        private HttpListenerContext _context;
        internal HttpListenerRequest request;
        internal HttpListenerResponse response;
        internal RequestInfoHandler currentRequestInfo;

        internal WebServer(string domain, ushort port)
        {
            _listener = new HttpListener();
            _listener.Prefixes.Add($"http://{domain}:{port}/");

            _listener.Start();
        }

        internal void ProcessRequest()
        {
            _context = _listener.GetContext();
            request = _context.Request;
            response = _context.Response;

            using (var memoryStream = new MemoryStream())
            {
                currentRequestInfo = new RequestInfoHandler();
                request.InputStream.CopyTo(memoryStream);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                var length = memoryStream.Length;
                var buffer = new byte[length];
                memoryStream.Read(buffer, 0, (int)length);


                //using (var istream = new StreamReader(memoryStream))
                //{
                //    istream.BaseStream.Position = 0;
                //    currentRequestInfo.RequestBodyContent = istream.ReadToEnd();
                //}
            }
        }

        internal void SendResult(byte[] result)
        {
            using (var ostream = response.OutputStream)
            {
                ostream.Write(result, 0, result.Length);
            }
        }

        internal void SendError(int code, byte[] result)
        {
            using (var ostream = response.OutputStream)
            {
                response.StatusCode = code;
                ostream.Write(result, 0, result.Length);
            }
        }
    }
}
