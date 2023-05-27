using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TestCloneBind.Models;

namespace TestCloneBind.ViewModels;

public partial class MainViewModel : ObservableRecipient
{
    public MainViewModel()
    {
        ButtonRandomClickedCommand = new RelayCommand(ButtonRandomClicked);
    }

    public ValueContainer ValueContainer
    {
        get;
    } = new();

    public RelayCommand ButtonRandomClickedCommand
    {
        get;
    }

    private void ButtonRandomClicked()
    {
        // Changes made to the cloned instance, not the bound instance, will be reflected to TextBox.
        // -> Solved: see ValueContainer.Clone()
        ValueContainer clone = ValueContainer.Clone();
        clone.Value = (Int32)Random.Shared.NextInt64();
        Debug.WriteLine("orig: " + ValueContainer.Value);
        Debug.WriteLine("clone: " + clone.Value);
    }
}
