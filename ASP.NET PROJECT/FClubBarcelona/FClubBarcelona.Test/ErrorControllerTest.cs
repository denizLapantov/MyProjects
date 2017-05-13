namespace FClubBarcelona.Test
{
    using Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestStack.FluentMVCTesting;

    [TestClass]
    public class ErrorControllerTest
    {
       
        private ErrorController controller;
      

        [TestInitialize]
        public void Init()
        {
            controller = new ErrorController();
        }

        [TestMethod]
        public void NotFoundActionShouldRenderViewActionNotFound()
        {
            controller.WithCallTo(x => x.NotFound()).ShouldRenderView("NotFound");
        }

        [TestMethod]
        public void NotFoundActionShouldRenderDefaultView()
        {
            controller.WithCallTo(x => x.NotFound()).ShouldRenderDefaultView();
        }

        [TestMethod]
        public void InternalServerActionShouldRenderViewActionInternalServer()  
        {
            controller.WithCallTo(x => x.InternalServer()).ShouldRenderView("InternalServer");
        }

        [TestMethod]
        public void InternalServerActionShouldRenderDefaultView()
        {
            controller.WithCallTo(x => x.InternalServer()).ShouldRenderDefaultView();

        }
    

    }
}
