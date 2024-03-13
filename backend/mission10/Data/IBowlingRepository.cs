namespace mission10.Data
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }
        IQueryable<BowlerResponse> GetBowlers();
    }
}
