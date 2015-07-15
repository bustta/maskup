using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(maskup.Startup))]
namespace maskup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
//             using(AirDbModel model = new AirDbModel())
//             {
//                 model.Database.CreateIfNotExists();
//             }
        }
    }
}
