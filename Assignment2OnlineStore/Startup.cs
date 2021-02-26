using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment2OnlineStore.Startup))]
namespace Assignment2OnlineStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
