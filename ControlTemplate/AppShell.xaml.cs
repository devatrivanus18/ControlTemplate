using ControlTemplate.Views;

namespace ControlTemplate;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(TestPage), typeof(TestPage));
        Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
        Routing.RegisterRoute(nameof(DataPage), typeof(DataPage));
        Routing.RegisterRoute(nameof(CustomTabelPage), typeof(CustomTabelPage));
        Routing.RegisterRoute(nameof(TransaksiPage), typeof(TransaksiPage));
    }
}
