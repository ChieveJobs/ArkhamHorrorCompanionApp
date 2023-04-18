namespace ArkhamHorrorCompanionApp;

public partial class PlayerPage : ContentPage
{
    private int _actionsTaken;
    public PlayerPage()
    {
        _actionsTaken = 0;
        InitializeComponent();
    }

    private void Done_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (((CheckBox)sender).IsChecked)
        {
            _actionsTaken++;
        }
        else
        {
            _actionsTaken--;
        }

        if (_actionsTaken == 3)
        {
            DoneButton.IsEnabled = true;
        }
        else
        {
            DoneButton.IsEnabled = false;  
        }
    }
}