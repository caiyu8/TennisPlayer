using System.Collections.Generic;
using TennisPlayer.API.Models;

namespace TennisPlayer.API.Repository
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> GetAllPlayers();

        bool TryGetPlayer(int id, out Player player);

        bool TryDeletePlayer(int id, out Player player);
    }
}
