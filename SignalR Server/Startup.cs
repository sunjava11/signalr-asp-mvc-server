using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalR_Server.Startup))]
namespace SignalR_Server
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
