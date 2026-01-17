using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Ahnenforscherin.App;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        //this.ContentFrame.Navigate(typeof(Workbench));
        var appWindow = this.AppWindow;
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
