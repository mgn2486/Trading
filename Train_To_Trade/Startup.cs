using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Train_To_Trade.Startup))]
namespace Train_To_Trade
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
