using Ahnenforscherin.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Ahnenforscherin.ViewModels;

public class PersonenViewModel : INotifyPropertyChanged
{
    private readonly IPersonRepository _repo;

    public ObservableCollection<Person> Personen { get; } = [];

    public PersonenViewModel(IPersonRepository repo)
    {
        _repo = repo;
    }

    private async Task LoadAsync()
    {
        IEnumerable<Person> list = _repo.GetAll();
        Personen.Clear();

        foreach (var p in list)
            Personen.Add(p);

        OnPropertyChanged(nameof(Personen));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged(string name)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
