namespace FClubBarcelona.Controllers
{
    using System.Web.Mvc;

    [RoutePrefix("Error")]
    public class ErrorController : Controller
    {
     
        [Route("NotFound")]
        public ActionResult NotFound()
        {
            return View();
        }

        [Route("InternalServer")]
        public ActionResult InternalServer()
        {   
            return View();
        }
    }
}