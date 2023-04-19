using ArkhamHorrorCompanionApp.Enums;

namespace ArkhamHorrorCompanionApp.Models
{
    public class GameSession
    {
        public int Turn { get; set; }

        public GamePhase GamePhase { get; set; }

        public List<Player> Players { get; set; }

        public int PlayerCount
        {
            get
            {
                return Players.Count;

            }
        }

        public GameSession()
        {
            Players = new List<Player>();
            Turn = 1;
        }
    }
}
