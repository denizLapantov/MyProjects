namespace FClubBarcelona.Test
{
    using Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestStack.FluentMVCTesting;

    [TestClass]
    public class ChatRoomControllerTests
    {
        private ChatRoomController controller;

        [TestInitialize]
        public void Init()
        {
            controller = new ChatRoomController();;
        }

        [TestMethod]
        public void ChatActionShoildRenderDefaultViwe()
        {
            controller.WithCallTo(x => x.Chat()).ShouldRenderDefaultView();
        }

        [TestMethod]
        public void ChatActionShoildRenderChatView()
        {
            controller.WithCallTo(x => x.Chat()).ShouldRenderView("Chat");
        }
    }
}
