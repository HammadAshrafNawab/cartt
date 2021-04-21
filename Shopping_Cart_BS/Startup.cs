using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shopping_Cart_BS.Startup))]
namespace Shopping_Cart_BS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
