using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorCompanionApp.Models
{
    public class Player
    {
        public int PlayerNumber { get; set; }
        public bool HasActed { get; set; }

        public Player(int playerNumber)
        {
            PlayerNumber = playerNumber;
            HasActed = false;
        }
    }
}
