using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PAUP_.Startup))]
namespace PAUP_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
