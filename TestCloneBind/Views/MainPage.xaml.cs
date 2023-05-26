using Microsoft.UI.Xaml.Controls;

using TestCloneBind.ViewModels;

namespace TestCloneBind.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
