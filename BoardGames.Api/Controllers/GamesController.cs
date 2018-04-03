using BoardGames.Api.Data;
using BoardGames.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace BoardGames.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : Controller
    {
        private readonly GamesDbContext _dbContext;
        private readonly ILogger<GamesController> _logger;

        public GamesController(GamesDbContext dbContext, ILogger<GamesController> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }
        
        [Authorize(Roles = "admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _logger.LogDebug($"Deleting game with id {id}");

            var game = await _dbContext.Games.FindAsync(id);
            if (game == null)
                return NotFound();

            _dbContext.Games.Remove(game);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll(int page = 1, int size = 10)
        {
            _logger.LogDebug("Getting one page of games");

            var count = _dbContext.Games.Count();
            var games = new PagedList<Game>
            {
                Items = _dbContext.Games.Skip((page - 1) * size).Take(size).ToArray(),
                Page = page,
                PageSize = size,
                TotalCount = count
            };
            
            return Ok(games);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            _logger.LogDebug($"Getting a game with id {id}");

            var game = _dbContext.Games.Find(id);

            if (game == null)
                return NotFound();

            return Ok(game);
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> Post(GameInput model)
        {
            _logger.LogDebug($"Creating a new game with title \"{model.Title}\"");

            var game = new Game();
            model.MapToGame(game);

            await _dbContext.Games.AddAsync(game);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction("GetById", new { id = game.Id });
        }

        [Authorize(Roles = "admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, GameInput model)
        {
            _logger.LogDebug($"Updating a game with id {id}");

            var game = await _dbContext.Games.FindAsync(id);

            if (game == null)
                return NotFound();

            model.MapToGame(game);

            await _dbContext.SaveChangesAsync();

            return Ok(game);
        }
    }
}
