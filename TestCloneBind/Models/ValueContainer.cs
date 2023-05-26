using CommunityToolkit.Mvvm.ComponentModel;

namespace TestCloneBind.Models;

public class ValueContainer : ObservableObject
{
    private Int32 _value;
    public Int32 Value
    {
        get => _value;
        set => SetProperty(ref _value, value);
    }

    public ValueContainer Clone()
    {
        return (ValueContainer)MemberwiseClone();
    }
}
