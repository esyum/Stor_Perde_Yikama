using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stor_Perde_Yikama.Startup))]
namespace Stor_Perde_Yikama
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
