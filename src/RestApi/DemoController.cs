using System.Web.Http;

namespace RestApi
{
    public class DemoController : ApiController
    {
        public string Get()
        {
            return "This is a self-hosted web api application!";
        }
    }
}
