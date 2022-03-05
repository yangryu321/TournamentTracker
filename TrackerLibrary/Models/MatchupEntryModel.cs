using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in this matchup
        /// </summary>
        /// 
        
        public int Id { get; set; }
        public TeamModel TeamCompeting { get; set; } = new TeamModel();

        //TODO--better to have an ID here?
        public int TeamCompetingId { get; set; }
        /// <summary>
        /// Represents the score of this team, starts with 0 and will be assined a new valune later on 
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Represents the last matchup where this team is the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; } = new MatchupModel();

        //Does it need this?
        //yes
        //cant give it its value until the matchup is saved to database and returns a id
        public int MatchupId { get; set; }

    }
}
