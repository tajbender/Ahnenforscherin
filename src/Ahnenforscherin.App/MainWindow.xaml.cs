using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Diagnostics;

namespace Ahnenforscherin.App;

public sealed partial class MainWindow : Window
{
    internal bool _extendsContentIntoTitleBar = false;
    internal UIElement? AppTitleBar = null;
    internal AppWindow? appWindow = null;

    public MainWindow()
    {
        Debug.WriteLine("MainWindow.ctor()");
        InitializeComponent();

        ExtendsContentIntoTitleBar = _extendsContentIntoTitleBar;

        if (AppTitleBar != null)
            SetTitleBar(AppTitleBar);
        var appWindow = this.AppWindow;

        //this.ContentFrame.Navigate(typeof(Workbench));
    }

    private void InitializeComponent()
    {

    }

    private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        if (args.SelectedItem is NavigationViewItem item)
        {
            switch (item.Tag)
            {
                case "workbench":
                    //ContentFrame.Navigate(typeof(Workbench));
                    break;

                case "settings":
                    //ContentFrame.Navigate(typeof(SettingsPage));
                    break;
            }
        }
    }
}
