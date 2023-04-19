using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkhamHorrorCompanionApp.Models
{
    public class Investigator
    {
        public int InvestigatorNumber { get; set; }
        public bool HasActed { get; set; }

        public Investigator(int investigatorNumber)
        {
            InvestigatorNumber = investigatorNumber;
            HasActed = false;
        }
    }
}
