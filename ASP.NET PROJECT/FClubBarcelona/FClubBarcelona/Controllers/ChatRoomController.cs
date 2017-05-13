namespace FClubBarcelona.Controllers
{
    using System.Web.Mvc;

    [RoutePrefix("ChatRoom")]
    public class ChatRoomController : Controller
    {
        // GET: ChatRoom
        [Route("Chat")]
        public ActionResult Chat()
        {
            return View();
        }
    }
}