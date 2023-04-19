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

    private async void DoneButton_Clicked(object sender, EventArgs e)
    {
		foreach(var investigator in _gameSession.Investigators)
		{
            investigator.HasActed = false;
		}

		_gameSession.Turn++;

		await Navigation.PopToRootAsync();
    }
}