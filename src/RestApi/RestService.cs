using Microsoft.Owin.Hosting;
using System;

namespace RestApi
{
    public class RestService
    {
        private IDisposable _app;

        public void Start()
        {
            _app = WebApp.Start<Startup>("http://localhost:8085");
        }

        public void Stop()
        {
            if (_app != null)
                _app.Dispose();
        }
    }
}
