using Ahnenforscherin.App.Views;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.UI.ApplicationSettings;

namespace Ahnenforscherin.App;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        //ContentFrame.Navigate(typeof(Workbench));
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