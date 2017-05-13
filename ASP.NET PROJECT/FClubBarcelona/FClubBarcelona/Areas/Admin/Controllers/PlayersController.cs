namespace FClubBarcelona.Areas.Admin.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Web.Mvc;
    using Attributes;
    using Models.BindingModels.Players;
    using Models.ViewModels.Players;
    using Service.Interfaces;

    [RouteArea("admin")]
    [RoutePrefix("Players")]
    [MyAuthorize(Roles = "Admin")]
    [HandleError]
    public class PlayersController : Controller
    {
        private IPlayersService service;

        public PlayersController(IPlayersService service)
        {
            this.service = service;
        }

        [Route("AllPlayers")]
        public ActionResult AllPlayers()
        {
            IEnumerable<PlaayersVm> model = service.GetAllPlayers();
            return View(model.ToList());
        }

        // GET: Admin/PlaayersVms/Create
        [Route("AddPlayer")]
        public ActionResult AddPlayer()
        {
            return View();
        }


        [Route("AddPlayer")]
        [HttpPost]
        public ActionResult AddPlayer(PlayersBm model)
        {
            var user = User.Identity.Name;

            if (ModelState.IsValid)
            {
                service.AddPlayer(model, user);
                RedirectToAction("AllPlayers");
            }

            return this.View(model);
        }

        [HttpGet]
        [Route("EditPlayer")]
        public ActionResult EditPlayer(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlaayersVm blogArticleBm = service.EditPlayer(id);
            if (blogArticleBm == null)
            {
                return HttpNotFound();
            }
            return  View(blogArticleBm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("EditPlayer")]
        public ActionResult EditPlayer([Bind(Include = "Id,FirstName,LastName,Age,DateOfBirth,Description,Position,ImageUrl,VideoUrl,Number,Nationality")] PlayersBm playersBm)
        {
            if (ModelState.IsValid)
            {
                service.Edit(playersBm);
                return RedirectToAction("AllPlayers");
            }
            return this.View(playersBm);
        }

        [Route("DeletePlayer")]
        public ActionResult DeletePlayer(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayersBm blogArticleBm = service.DeletePlayer(id);
            if (blogArticleBm == null)
            {
                return HttpNotFound();
            }
            return View(blogArticleBm);
        }

        // POST: BlogArticleBms/Delete/5
        [HttpPost, ActionName("DeletePlayer")]
        [ValidateAntiForgeryToken]
        [Route("DeletePlayer")]
        public ActionResult DeleteConfirmed(int? id)
        {

            service.Delete(id);
            return RedirectToAction("AllPlayers");
        }
    }
}
