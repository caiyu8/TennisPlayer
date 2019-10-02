using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennisPlayer.API.Models;

namespace TennisPlayer.API.Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        List<Player> Players;

        public PlayerRepository()
        {
            Players = JsonHelper.ImportPlayers().OrderBy(p => p.Id).ToList();
        }

        public IEnumerable<Player> GetAllPlayers() => Players;

        public bool TryDeletePlayer(int id, out Player player)
        {
            player = Players.FirstOrDefault(p => p.Id == id);
            Players.Remove(player);

            return (player != null);
        }

        public bool TryGetPlayer(int id, out Player player)
        {
            player = Players.FirstOrDefault(p => p.Id == id);
            return (player != null);
        }
    }
}
