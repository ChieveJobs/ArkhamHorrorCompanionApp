namespace ArkhamHorrorCompanionApp.Models
{
    public class GameSession
    {
        public int Turn { get; set; }

        public List<Investigator> Investigators { get; set; }

        public int InvestigatorCount
        {
            get
            {
                return Investigators.Count;

            }
        }

        public GameSession()
        {
            Investigators = new List<Investigator>();
            Turn = 1;
        }
    }
}
