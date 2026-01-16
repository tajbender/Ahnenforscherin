using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Ahnenforscherin.App.Views;

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
            }
        }
    }
}