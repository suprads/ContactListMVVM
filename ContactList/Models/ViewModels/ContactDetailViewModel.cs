
using CommunityToolkit.Mvvm.ComponentModel;

namespace ContactList.Models.ViewModels;

partial class ContactDetailViewModel : ObservableObject
{
    [ObservableProperty]
    private Contact contact;
}