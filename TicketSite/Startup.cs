using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TicketSite.Startup))]
namespace TicketSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
