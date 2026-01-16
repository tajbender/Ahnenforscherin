using Microsoft.UI.Xaml;
using System.Diagnostics;

namespace Ahnenforscherin.App;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
    }

    private void InitializeComponent()
    {
        Debug.Print("Hello World!\nHeureka.");
    }
}
