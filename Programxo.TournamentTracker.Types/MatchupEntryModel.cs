using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programxo.TournamentTracker.Types
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one Team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for this particular team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup that this team came from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }


    }
}
