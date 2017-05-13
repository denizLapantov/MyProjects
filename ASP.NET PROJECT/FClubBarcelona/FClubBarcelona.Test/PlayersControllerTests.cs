namespace FClubBarcelona.Test
{
    using System.Collections.Generic;
    using Areas.Admin.Controllers;
    using Models.ViewModels.Players;
    using Service;
    using Service.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestStack.FluentMVCTesting;

    [TestClass]
    public class PlayersControllerTests
    {
        private PlayersController controller;
        private IPlayersService service;
        private ConfigureMapping mapping;


        public PlayersControllerTests()
        {
            service = new PlayersService();
            controller = new PlayersController(service);
            mapping = new ConfigureMapping();
            mapping.ConfigureMaping();
        }

        [TestMethod]
        public void AllPlayersActionShouldRenderViewAllPlayers()
        {
            controller.WithCallTo(x => x.AllPlayers())
                .ShouldRenderDefaultView()
                .WithModel<IEnumerable<PlaayersVm>>();
        }

        [TestMethod]
        public void AllPlayersActionShouldRenderDefaultView()
        {
            controller.WithCallTo(x => x.AllPlayers())
                .ShouldRenderView("AllPlayers")
                .WithModel<IEnumerable<PlaayersVm>>();
        }

        [TestMethod]
        public void AddPlayerActionShouldRenderViewAddPlayer()
        {
            controller.WithCallTo(x => x.AddPlayer())
                .ShouldRenderDefaultView();

        }

        [TestMethod]
        public void AddPlayerActionShouldRenderDefaultView()
        {
            controller.WithCallTo(x => x.AddPlayer())
                .ShouldRenderView("AddPlayer");

        }
    }
}
