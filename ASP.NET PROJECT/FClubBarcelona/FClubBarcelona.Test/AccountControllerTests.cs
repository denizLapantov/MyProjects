namespace FClubBarcelona.Test
{
    using Controllers;
    using Service;
    using Service.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestStack.FluentMVCTesting;

    [TestClass]
    public class AccountControllerTests
    {
        private AccountController controller;
        private IAccountService service;
        private ConfigureMapping mapping;


        public AccountControllerTests()
        {
            service = new AccountService();
            controller = new AccountController();
            mapping = new ConfigureMapping();
            mapping.ConfigureMaping();
        }

        [TestMethod]
        public void RegisterActionShouldRenderViewRegister()
        {
            controller.WithCallTo(x => x.Register())
                .ShouldRenderDefaultView();

        }
            
        [TestMethod]
        public void RegisterActionShouldRenderDefaultView()
        {
            controller.WithCallTo(x => x.Register())
                .ShouldRenderView("Register");
        }
    }
}
