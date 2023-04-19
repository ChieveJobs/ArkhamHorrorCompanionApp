using ArkhamHorrorCompanionApp.Models;

namespace ArkhamHorrorCompanionApp.Pages;

public partial class MythosPhasePage : ContentPage
{
    private int _enounterCardsDrawn;
    private readonly GameSession _gameSession;

	public MythosPhasePage()
	{
        Appearing += MythosPhasePage_Appearing;
        InitializeComponent();
    }

    private void MythosPhasePage_Appearing(object sender, EventArgs e)
    {
        if(_gameSession == null)
        {
            Navigation.PushModalAsync(new StartPage()); 
        }

        if (_gameSession != null && _gameSession.Turn == 1)
        {
            SkipButton.IsVisible = true;
        }
    }

    private void AddMythosButton_Clicked(object sender, EventArgs e)
    {
        Investigator1Label.IsVisible = true;
        Investigator1Checkbox.IsVisible = true;

        if (_gameSession.InvestigatorCount > 1)
        {
            Investigator2Label.IsVisible = true;
            Investigator2Checkbox.IsVisible = true;
        }
        if (_gameSession.InvestigatorCount > 2)
        {
            Investigator3Label.IsVisible = true;
            Investigator3Checkbox.IsVisible = true;
        }
        if (_gameSession.InvestigatorCount > 3)
        {
            Investigator4Label.IsVisible = true;
            Investigator4Checkbox.IsVisible = true;
        }
    }

    private void DoneButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new InvestigationPhasePage(_gameSession));
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

        if (_enounterCardsDrawn == _gameSession.InvestigatorCount)
        {
            DoneButton.IsVisible = true;
        }
        else
        {
            DoneButton.IsVisible = false;
        }
    }
}