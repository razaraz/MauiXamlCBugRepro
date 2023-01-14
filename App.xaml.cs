namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
        InitializeComponent();

        Resources.Add(new ResourceDictionary().LoadFromXaml(typeof(ColorResources)));

		MainPage = new AppShell();
	}
}
