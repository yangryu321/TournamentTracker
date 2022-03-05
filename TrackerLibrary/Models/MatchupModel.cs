using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public int Id { get; set; }
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        public TeamModel Winner { get; set; }
         
        //for database use
        public string WinnerId { get; set; }
        public int MatchupRound { get; set; }
        public int TournamentId { get; set; }

        public string Matchupteams { 
            get
            {
                int count = 0;
                string line="";
                foreach (var entry in Entries)
                {
                    if(Entries.Count()>1)
                    {
                        if (entry.TeamCompeting != null)
                            line += $"{entry.TeamCompeting.TeamName}--VS--";
                        else
                            line += $"{"___"}--VS--";
                    }
                    else
                    {
                        line += $"{entry.TeamCompeting.TeamName}--VS--{"bot"}";
                    }

                    count++;
                }


                if (line != "" && count == 2)
                    line = line.Substring(0, line.Length - 6);
                else if (line != "" && count == 1)
                    return line;


                return line;
            }
        }

    }
}
