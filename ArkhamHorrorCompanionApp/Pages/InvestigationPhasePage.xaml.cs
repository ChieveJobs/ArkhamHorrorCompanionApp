using ArkhamHorrorCompanionApp.Models;

namespace ArkhamHorrorCompanionApp.Pages;

public partial class InvestigationPhasePage : ContentPage
{
    private readonly GameSession _gameSession;

    public InvestigationPhasePage(GameSession gameSession)
    {
        _gameSession = gameSession;
        Appearing += InvestigationPhasePage_Appearing;
        InitializeComponent();
        InitializePlayers();
    }

    private void InitializePlayers()
    {
        if (_gameSession.PlayerCount > 1)
        {
            Player2Image.IsVisible = true;
        }
        if (_gameSession.PlayerCount > 2)
        {
            Player3Image.IsVisible = true;
        }
        if (_gameSession.PlayerCount > 3)
        {
            Player4Image.IsVisible = true;
        }
    }

    private void InvestigationPhasePage_Appearing(object sender, EventArgs e)
    {
        var allActed = true;
        foreach (var player in _gameSession.Players)
        {
            if (player.HasActed == false)
            {
                allActed = false;
            }
        }

        if (allActed)
        {
            EnemyPhaseButton.IsVisible = true;
        }
        else
        {
            EnemyPhaseButton.IsVisible = false;
        }
    }

    private void Player1Image_Clicked(object sender, EventArgs e)
    {
        ShowPlayerPage(0);
    }

    private void Player2Image_Clicked(object sender, EventArgs e)
    {
        ShowPlayerPage(1);
    }

    private void ShowPlayerPage(int position)
    {
        if (!_gameSession.Players.ElementAt(position).HasActed)
        {
            Navigation.PushAsync(new PlayerTurnPage(_gameSession, position));
        }
    }

    private void EnemyPhase_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EnemyPhasePage(_gameSession));
    }
}