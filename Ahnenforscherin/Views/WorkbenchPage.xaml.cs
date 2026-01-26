using Ahnenforscherin.Models;
using Ahnenforscherin.Repositories;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Ahnenforscherin.Views;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class WorkbenchPage : Page
{
    public WorkbenchPage()
    {
        InitializeComponent();

        var repo = new InMemoryPersonRepository();
        var dummies = PersonFactory.CreateSampleFamily();

        foreach (var p in dummies)
            repo.Add(p);
    }

    private void CreatePerson_Click(object sender, RoutedEventArgs e)
    {
        SetStatus("Neue Person anlegen (Dummy)...");
        // TODO: Navigation zu PersonEditor
    }

    private void OpenPersonList_Click(object sender, RoutedEventArgs e)
    {
        SetStatus("Personenliste öffnen (Dummy)...");
        // TODO: Navigation zu PersonList
    }

    private void ImportGedcom_Click(object sender, RoutedEventArgs e)
    {
        SetStatus("GEDCOM importieren (Dummy)...");
        // TODO: FilePicker + Parser
    }

    private void ExportGedcom_Click(object sender, RoutedEventArgs e)
    {
        SetStatus("GEDCOM exportieren (Dummy)...");
        // TODO: Exportfunktion
    }

    private void OpenTree_Click(object sender, RoutedEventArgs e)
    {
        SetStatus("Stammbaum öffnen (Dummy)...");
        // TODO: TreeView öffnen
    }

    private void CreateTree_Click(object sender, RoutedEventArgs e)
    {
        SetStatus("Neuen Stammbaum erstellen (Dummy)...");
        // TODO: Tree-Setup
    }

    private void SetStatus(string message)
    {
        // StatusText.Text = message;
    }
}
