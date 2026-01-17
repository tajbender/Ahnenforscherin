using Microsoft.UI.Xaml;
using System.Diagnostics;

namespace Ahnenforscherin.App;

public partial class App : Application
{
    private readonly Window? _window;

    /// <summary>
    /// Initializes the singleton application object.  This is the first line of authored code
    /// executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    public App()
    {
        Debug.WriteLine("App.ctor()");
        this.InitializeComponent();

        Debug.WriteLine("App(new this*)");
        this._window = new MainWindow();
        this._window?.Activate();
    }

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        Debug.WriteLine("App.OnLaunched()");
        this._window?.Activate();
    }
}
