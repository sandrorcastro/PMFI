using FiscalMobile.Views;

namespace FiscalMobile
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(VistoriaPage), typeof(VistoriaPage));
            Routing.RegisterRoute(nameof(PerfilAppPage), typeof(PerfilAppPage));
            Routing.RegisterRoute(nameof(ProcessoListPage), typeof(ProcessoListPage));
        }
    }
}