using ArkhamHorrorCompanionApp.Models;

namespace ArkhamHorrorCompanionApp.Pages;

public partial class InvestigatorTurnPage : ContentPage
{
    private int _actionsTaken;
    private readonly int _investigatorNumber;
    private readonly GameSession _gameSession;
    public InvestigatorTurnPage(GameSession gameSession, int investigatorNumber)
    {
        _gameSession = gameSession;
        _investigatorNumber = investigatorNumber;   
        _actionsTaken = 0;
        InitializeComponent();
        InvestigatorLabel.Text = "Investigator " + (investigatorNumber + 1);
    }

    private void Done_Clicked(object sender, EventArgs e)
    {
        _gameSession.Investigators.ElementAt(_investigatorNumber).HasActed = true;
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