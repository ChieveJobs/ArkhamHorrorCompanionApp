using ArkhamHorrorCompanionApp.Models;

namespace ArkhamHorrorCompanionApp;

public partial class MainPage : ContentPage
{
    private readonly GameSession _gameSession;

    public MainPage(GameSession gameSession)
    {
        _gameSession = gameSession;
        InitializeComponent();
        InitializePlayers();
    }

    private void InitializePlayers()
    {
        switch (_gameSession.PlayerCount)
        {
            case 1:
                Player1Image.IsVisible = true;
                break;
            case 2:
                Player1Image.IsVisible = true;
                Player2Image.IsVisible = true;
                break;
            case 3:
                Player1Image.IsVisible = true;
                Player2Image.IsVisible = true;
                Player3Image.IsVisible = true;
                break;
            case 4:
                Player1Image.IsVisible = true;
                Player2Image.IsVisible = true;
                Player3Image.IsVisible = true;
                Player4Image.IsVisible = true;
                break;
            default:
                throw new Exception();
        }
    }

    private void Player1Image_Clicked(object sender, EventArgs e)
    {
        if (!_gameSession.Players.ElementAt(0).HasActed) 
        {
            Navigation.PushAsync(new PlayerPage());
        }
    }

    private void Player2Image_Clicked(object sender, EventArgs e)
    {

    }
}