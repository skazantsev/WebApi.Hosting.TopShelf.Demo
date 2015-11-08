using Topshelf;

namespace RestApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<RestService>(s =>
                {
                    s.ConstructUsing(() => new RestService());
                    s.WhenStarted(rs => rs.Start());
                    s.WhenStopped(rs => rs.Stop());
                    s.WhenShutdown(rs => rs.Stop());
                });
                x.RunAsLocalSystem();
                x.StartAutomatically();

                x.SetServiceName("WebApiRestService");
                x.SetDisplayName("WebApiRestService");
                x.SetDescription("This is an example of self-hosted web api rest service.");
            });
        }
    }
}
