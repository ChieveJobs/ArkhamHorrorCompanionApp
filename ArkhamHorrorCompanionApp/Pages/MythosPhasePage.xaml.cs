using ArkhamHorrorCompanionApp.Models;

namespace ArkhamHorrorCompanionApp.Pages;

public partial class MythosPhasePage : ContentPage
{
    private int _enounterCardsDrawn;
    private readonly GameSession _gameSession;

	public MythosPhasePage(GameSession gameSession)
	{
		_gameSession = gameSession;
        InitializeComponent();
    }

    private void AddMythosButton_Clicked(object sender, EventArgs e)
    {
        Investigator1Label.IsVisible = true;
        Investigator1Checkbox.IsVisible = true;
        if (_gameSession.PlayerCount > 1)
        {
            Investigator2Label.IsVisible = true;
            Investigator2Checkbox.IsVisible = true;
        }
        if (_gameSession.PlayerCount > 2)
        {
            Investigator3Label.IsVisible = true;
            Investigator3Checkbox.IsVisible = true;
        }
        if (_gameSession.PlayerCount > 3)
        {
            Investigator4Label.IsVisible = true;
            Investigator4Checkbox.IsVisible = true;
        }
    }

    private void DoneButton_Clicked(object sender, EventArgs e)
    {

    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (((CheckBox)sender).IsChecked)
        {
            _enounterCardsDrawn++;
        }
        else
        {
            _enounterCardsDrawn--;
        }

        if (_enounterCardsDrawn == _gameSession.PlayerCount)
        {
            DoneButton.IsVisible = true;
        }
        else
        {
            DoneButton.IsVisible = false;
        }
    }
}