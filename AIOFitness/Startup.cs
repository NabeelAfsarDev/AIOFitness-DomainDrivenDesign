using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AIOFitness.Startup))]
namespace AIOFitness
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
