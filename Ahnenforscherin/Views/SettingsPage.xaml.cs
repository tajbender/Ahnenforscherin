using Ahnenforscherin.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Ahnenforscherin.Views;

// TODO: Set the URL for your privacy policy by updating SettingsPage_PrivacyTermsLink.NavigateUri in Resources.resw.
public sealed partial class SettingsPage : Page
{
    public SettingsViewModel ViewModel
    {
        get;
    }

    public SettingsPage()
    {
        //        ViewModel = App.GetService<SettingsViewModel>();
        InitializeComponent();

        var version = System.Reflection.Assembly
            .GetExecutingAssembly().GetName().Version?.ToString() ?? "undefined!";

        VersionText.Text = version;
    }
}
