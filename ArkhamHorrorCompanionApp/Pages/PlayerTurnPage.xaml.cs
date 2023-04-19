using ArkhamHorrorCompanionApp.Models;

namespace ArkhamHorrorCompanionApp.Pages;

public partial class PlayerTurnPage : ContentPage
{
    private int _actionsTaken;
    private readonly int _playerNumber;
    private GameSession _gameSession;
    public PlayerTurnPage(GameSession gameSession, int playerNumber)
    {
        _gameSession = gameSession;
        _playerNumber = playerNumber;
        _actionsTaken = 0;
        InitializeComponent();
    }

    private void Done_Clicked(object sender, EventArgs e)
    {
        _gameSession.Players.ElementAt(_playerNumber).HasActed = true;
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