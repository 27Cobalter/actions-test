using BootstrapperUI;
using WixToolset.Mba.Core;

[assembly: BootstrapperApplicationFactory(typeof(WpfBaFactory))]

namespace BootstrapperUI
{
    public class WpfBaFactory : BaseBootstrapperApplicationFactory
    {
        protected override IBootstrapperApplication Create(IEngine engine, IBootstrapperCommand bootstrapperCommand)
        {
            var ba = new CustomBootstrapper(engine);
            return ba;
        }
    }
}
