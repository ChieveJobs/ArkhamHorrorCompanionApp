﻿using ArkhamHorrorCompanionApp.Enums;
using ArkhamHorrorCompanionApp.Models;

namespace ArkhamHorrorCompanionApp;

public partial class StartPage : ContentPage
{
    public StartPage()
    {
        InitializeComponent();
    }

    private async void Begin_Clicked(object sender, EventArgs e)
    {
        var selectedValue = PlayerCountPicker.SelectedIndex;

        if (selectedValue != -1)
        {
            var gameSession = new GameSession((selectedValue + 1));

            for (int i = 0; i < (selectedValue + 1); i++)
            {
                gameSession.Players.Add(new Player((i + 1)));
            }
            await Navigation.PushAsync(new MainPage(gameSession));
        }
        else
        {
            WarningLabel.IsVisible= true;
        }

    }
}

