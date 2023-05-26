using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TestCloneBind.Models;

namespace TestCloneBind.ViewModels;

public partial class MainViewModel : ObservableRecipient
{
    public MainViewModel()
    {
        ButtonIncrementClickedCommand = new RelayCommand(ButtonIncrementClicked);
    }

    public ValueContainer ValueContainer
    {
        get;
        set;
    } = new();

    public RelayCommand ButtonIncrementClickedCommand
    {
        get;
    }

    private void ButtonIncrementClicked()
    {
        ValueContainer.Value++;
    }
}
