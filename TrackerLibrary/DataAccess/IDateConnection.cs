using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDateConnection
    {
        PrizeModel createPrize(PrizeModel model);
        PersonModel createPerson(PersonModel model);
        TeamModel createTeam(TeamModel model);

        TournamentModel createTournament(TournamentModel model);
        List<PersonModel> Get_All_Person();
        List<TeamModel> Get_ALL_Team();

        List<TournamentModel> Get_ALL_Tournaments();

        void Update(MatchupModel model);

    }
}
