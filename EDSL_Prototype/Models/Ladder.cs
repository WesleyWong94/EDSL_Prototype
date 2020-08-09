using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSL_Prototype
{
    class Ladder
    {
        public string Team { get; set; }
        public int Ranking { get; set; }
        public int GamesPlayed { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public int Points { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public Ladder()
        {
        }

        public Ladder(string team, int ranking, int gamesPlayed, int wins, int draws, int losses, int points, int goalsFor, int goalsAgainst)
        {
            Team = team;
            Ranking = ranking;
            GamesPlayed = gamesPlayed;
            Wins = wins;
            Draws = draws;
            Losses = losses;
            Points = points;
            GoalsFor = goalsFor;
            GoalsAgainst = goalsAgainst;

        }

    }
}
