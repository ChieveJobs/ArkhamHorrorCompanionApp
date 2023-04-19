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
        InitializeInvestigators();
    }

    private void InitializeInvestigators()
    {
        if (_gameSession.InvestigatorCount > 1)
        {
            Investigator2Image.IsVisible = true;
        }
        if (_gameSession.InvestigatorCount > 2)
        {
            Investigator3Image.IsVisible = true;
        }
        if (_gameSession.InvestigatorCount > 3)
        {
            Investigator4Image.IsVisible = true;
        }
    }

    private void InvestigationPhasePage_Appearing(object sender, EventArgs e)
    {
        var allActed = true;

        foreach (var investigator in _gameSession.Investigators)
        {
            if (investigator.HasActed == false)
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

    private void Investigator1Image_Clicked(object sender, EventArgs e)
    {
        ShowInvestigatorPage(0);
    }

    private void Investigator2Image_Clicked(object sender, EventArgs e)
    {
        ShowInvestigatorPage(1);
    }

    private void Investigator3Image_Clicked(object sender, EventArgs e)
    {
        ShowInvestigatorPage(2);
    }

    private void Investigator4Image_Clicked(object sender, EventArgs e)
    {
        ShowInvestigatorPage(3);
    }

    private void ShowInvestigatorPage(int position)
    {
        if (!_gameSession.Investigators.ElementAt(position).HasActed)
        {
            Navigation.PushAsync(new InvestigatorTurnPage(_gameSession, position));
        }
    }

    private void EnemyPhase_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EnemyPhasePage(_gameSession));
    }
}