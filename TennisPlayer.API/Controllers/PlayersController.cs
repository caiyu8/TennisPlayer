using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TennisPlayer.API.Models;
using TennisPlayer.API.Repository;

namespace TennisPlayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        IPlayerRepository playerRepository;

        public PlayersController(IPlayerRepository playerRepo)
        {
            playerRepository = playerRepo;
        }

        // GET: api/Players
        /// <summary>
        /// Get all tennis players
        /// </summary>
        /// <returns>An array of tennis players</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Player>> Get()
        {
            var players = playerRepository.GetAllPlayers();

            return players.ToList();
        }


        // GET: api/Players/5
        /// <summary>
        /// Return a specific player
        /// </summary>
        /// <param name="id">Player Id</param>
        /// <returns>A tennis player</returns>
        [HttpGet("{id}")]
        public ActionResult<Player> Get(int id)
        {
            if (!playerRepository.TryGetPlayer(id, out Player player))
            {
                return NotFound();
            }

            return player;
        }


        // DELETE: api/ApiWithActions/5
        /// <summary>
        /// Remove a tennis player
        /// </summary>
        /// <param name="id">Player Id</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!playerRepository.TryDeletePlayer(id, out Player player))
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}