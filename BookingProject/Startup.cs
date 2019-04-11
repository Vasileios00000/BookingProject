using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookingProject.Startup))]
namespace BookingProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
