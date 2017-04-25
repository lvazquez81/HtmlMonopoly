using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HtmlMonopolyOne.Startup))]
namespace HtmlMonopolyOne
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
