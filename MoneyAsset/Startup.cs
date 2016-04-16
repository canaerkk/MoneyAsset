using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoneyAsset.Startup))]
namespace MoneyAsset
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
