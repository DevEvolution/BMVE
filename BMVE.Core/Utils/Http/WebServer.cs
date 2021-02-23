using System;
using System.Collections.Generic;
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
