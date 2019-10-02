using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using TennisPlayer.API.Controllers;
using TennisPlayer.API.Models;
using TennisPlayer.API.Repository;

namespace TennisPlayer.API.Tests
{
    [TestClass]
    public class PlayersControllerTest
    {
        PlayersController _playersController;
        IPlayerRepository _playersRepo;

        public PlayersControllerTest()
        {
            _playersRepo = new FakePlayersRepo();
            _playersController = new PlayersController(_playersRepo);
        }

        [TestMethod]
        public void Get_ShouldReturnAllPlayers()
        {
            var testData = _playersRepo.GetAllPlayers() as List<Player>;
            var result = _playersController.Get().Value as List<Player>;

            CollectionAssert.AreEqual(testData, result);
        }

        [DataTestMethod]
        [DataRow(52)]
        [DataRow(17)]
        public void Get_ShouldReturnSpecificPlayer(int id)
        {
            var result = _playersController.Get(id);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result.Value, typeof(Player));
            Assert.AreEqual(id, result.Value.Id);
        }

        [DataTestMethod]
        [DataRow(30)]
        [DataRow(31)]
        public void Get_ShouldReturnNotFoundResult(int id)
        {
            var result = _playersController.Get(id);
            Assert.IsInstanceOfType(result.Result, typeof(NotFoundResult));
        }

        [DataTestMethod]
        [DataRow(52)]
        [DataRow(17)]
        public void Delete_ShouldReturnNoContentResult(int id)
        {
            var countBeforeDelete = _playersRepo.GetAllPlayers().Count();

            var result = _playersController.Delete(id);

            var countAfterDelete = _playersRepo.GetAllPlayers().Count();

            Assert.IsInstanceOfType(result, typeof(NoContentResult));
            Assert.AreEqual(countBeforeDelete - 1, countAfterDelete);
        }

        [DataTestMethod]
        [DataRow(30)]
        [DataRow(31)]
        public void Delete_ShouldReturnNoFoundResult(int id)
        {
            var result = _playersController.Delete(id);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
    }
}
