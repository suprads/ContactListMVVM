

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ContactList.Models.ViewModels;

partial class ContactListViewModel:ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Contact> contacts = new();

    [ObservableProperty]
    private Contact contact = new();

    [RelayCommand]
    private void Add()
    {
        Contacts.Add(Contact);
        Contact = new();
    }
}
