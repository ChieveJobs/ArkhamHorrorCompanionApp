using ArkhamHorrorCompanionApp.Models;

namespace ArkhamHorrorCompanionApp.Pages;

public partial class UpkeepPhasePage : ContentPage
{
	private readonly GameSession _gameSession;
	public UpkeepPhasePage(GameSession gameSession)
	{
		_gameSession = gameSession;
		InitializeComponent();
	}

    private void DoneButton_Clicked(object sender, EventArgs e)
    {
		foreach(var player in _gameSession.Players)
		{
			player.HasActed = false;
		}

		_gameSession.Turn = _gameSession.Turn++;
    }
}