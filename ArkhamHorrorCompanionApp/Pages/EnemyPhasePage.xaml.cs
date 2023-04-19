using ArkhamHorrorCompanionApp.Models;

namespace ArkhamHorrorCompanionApp.Pages;

public partial class EnemyPhasePage : ContentPage
{
	private readonly GameSession _gameSession;

	public EnemyPhasePage(GameSession gameSession)
	{
		_gameSession = gameSession;
		InitializeComponent();
	}

    private void MoveButton_Clicked(object sender, EventArgs e)
    {
		AttackLabel.IsVisible = true;
        AttackEnemyImage.IsVisible= true;
        AttackClawImage.IsVisible= true;
        AttackButton.IsVisible= true;
    }

    private void AttackButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new UpkeepPhasePage(_gameSession));
    }
}