using System.Windows.Threading;
using WixToolset.Mba.Core;

namespace BootstrapperUI
{
    public class CustomBootstrapper : BootstrapperApplication
    {
        private readonly IEngine _engine;
        public CustomBootstrapper(IEngine engine) : base(engine) {
            _engine = engine;
        }

        protected override void Run()
        {
            var dispatcher = Dispatcher.CurrentDispatcher;
            var w = new MainView();
            w.Closed += (_, __) => dispatcher.InvokeShutdown();

            _engine.Detect();
            w.Show();
            Dispatcher.Run();
            _engine.Quit(0);
        }
    }
}
