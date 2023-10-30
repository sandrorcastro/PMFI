using VistoriaInLoco.Views;

namespace VistoriaInLoco
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(VistoriaPage), typeof(VistoriaPage));
        }
    }
}