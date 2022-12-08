namespace ChatApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(Views.HomeView), typeof(Views.HomeView));
        Routing.RegisterRoute(nameof(Views.DetailView), typeof(Views.DetailView));
    }
}
