namespace BlazorWebAppMovies.Components;

public partial class ReferenceChild {

    private int _value;

    public void ChildMethod(int value)
    {
        this._value = value;
        StateHasChanged();
    }
}