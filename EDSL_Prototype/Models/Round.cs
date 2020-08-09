using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSL_Prototype
{
    class Round
    {
        public int RoundNumber { get; set; }
        public string RoundDate { get; set; }

        public Round()
        {
        }

        public Round(int roundNumber, string roundDate)
        {
            RoundNumber = roundNumber;
            RoundDate = roundDate;
        }
    }
}
