using ArkhamHorrorCompanionApp.Models;

namespace ArkhamHorrorCompanionApp.Pages;

public partial class StartPage : ContentPage
{
    private GameSession _gameSession;
    public StartPage()
    {
        InitializeComponent();
    }

    private async void Begin_Clicked(object sender, EventArgs e)
    {
        var selectedValue = InvestigatorCountPicker.SelectedIndex;

        if (selectedValue != -1)
        {
            _gameSession = new GameSession();

            for (int i = 0; i < (selectedValue + 1); i++)
            {
                _gameSession.Investigators.Add(new Investigator((i + 1)));
            }

            await Navigation.PushAsync(new MythosPhasePage());
        }
        else
        {
            WarningLabel.IsVisible = true;
        }

    }
}

