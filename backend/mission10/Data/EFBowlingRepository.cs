using System.Linq;

namespace mission10.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlingContext;
        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _bowlingContext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlingContext.Bowlers;

        public IEnumerable<Team> Teams => _bowlingContext.Teams;

        public IQueryable<BowlerResponse> GetBowlers()
        {
            var query = from Bowler in _bowlingContext.Bowlers
                        join Team in _bowlingContext.Teams on Bowler.TeamId equals Team.TeamId
                        where Team.TeamName == "Marlins" || Team.TeamName == "Sharks"
                        select new BowlerResponse
                        {
                            BowlerId = Bowler.BowlerId,
                            BowlerLastName = Bowler.BowlerLastName,
                            BowlerFirstName = Bowler.BowlerFirstName,
                            BowlerMiddleInit = Bowler.BowlerMiddleInit,
                            BowlerAddress = Bowler.BowlerAddress,
                            BowlerCity = Bowler.BowlerCity,
                            BowlerState = Bowler.BowlerState,
                            BowlerZip = Bowler.BowlerZip,
                            BowlerPhoneNumber = Bowler.BowlerPhoneNumber,
                            TeamName = Team.TeamName
                        };
            return query;
        }

    }
}
