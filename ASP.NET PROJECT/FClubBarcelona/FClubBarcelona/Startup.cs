using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FClubBarcelona.Startup))]
namespace FClubBarcelona
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
