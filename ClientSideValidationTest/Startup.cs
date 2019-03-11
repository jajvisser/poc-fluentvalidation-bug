using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClientSideValidationTest.Startup))]
namespace ClientSideValidationTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
