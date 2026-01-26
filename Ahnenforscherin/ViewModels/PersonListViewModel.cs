using Ahnenforscherin.Models;
using System.Collections.ObjectModel;

namespace Ahnenforscherin.ViewModels;

public class PersonListViewModel
{
    private readonly IPersonRepository _repo;

    public ObservableCollection<Person> Persons { get; } = new();

    public PersonListViewModel(IPersonRepository repo)
    {
        _repo = repo;

        foreach (var p in repo.GetAll())
            Persons.Add(p);
    }
}
