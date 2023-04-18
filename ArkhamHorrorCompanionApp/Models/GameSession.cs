using ArkhamHorrorCompanionApp.Enums;

namespace ArkhamHorrorCompanionApp.Models
{
    public class GameSession
    {
        public int Turn { get; set; }

        public GamePhase GamePhase { get; set; }

        public int PlayerCount { get; set; }
        
        public List<Player> Players { get; set; }

        public GameSession(int playerCount)
        {
            this.PlayerCount = playerCount;
            Players = new List<Player>();  
        }
    }
}
