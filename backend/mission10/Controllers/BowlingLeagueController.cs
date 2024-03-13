using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mission10.Data;

namespace mission10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlingLeagueController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }

        [HttpGet]
        public IEnumerable<BowlerResponse> GetBowlers()
        {
            var bowlingData = _bowlingRepository.GetBowlers().ToArray();

            return bowlingData;
        }
    }
}
