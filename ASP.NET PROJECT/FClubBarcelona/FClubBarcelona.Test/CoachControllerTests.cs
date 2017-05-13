namespace FClubBarcelona.Test
{
    using System.Collections.Generic;
    using Areas.Admin.Controllers;
    using Models.ViewModels.Coaches;
    using Service;
    using Service.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestStack.FluentMVCTesting;

    [TestClass]
    public class CoachControllerTests
    {
        private CoachController controller;
        private ICoachService service;
        private ConfigureMapping mapping;


        public CoachControllerTests()
        {
            service = new CoachService();
            controller = new CoachController(service);
            mapping = new ConfigureMapping();
            mapping.ConfigureMaping();
        }

        [TestMethod]
        public void AllCoachesActionShouldRenderDefaultView()
        {
            controller.WithCallTo(x => x.AllCoaches())
                .ShouldRenderView("AllCoaches")
                .WithModel<IEnumerable<CoachVm>>();
        }

        [TestMethod]
        public void AllCoachesActionShouldRenderViewAllCoaches()
        {
            controller.WithCallTo(x => x.AllCoaches())
                .ShouldRenderDefaultView();

        }

        [TestMethod]
        public void AddCoachActionShouldRenderDefaultView()
        {
            controller.WithCallTo(x => x.AddCoach())
                .ShouldRenderView("AddCoach");

        }

        [TestMethod]
        public void AddCoachActionShouldRenderViewAddCoach()
        {
            controller.WithCallTo(x => x.AddCoach())
                .ShouldRenderDefaultView();

        }
    }
}
