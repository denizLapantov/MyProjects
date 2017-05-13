namespace FClubBarcelona.Areas.Admin.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Web.Mvc;
    using Attributes;
    using Models.ViewModels.Coaches;
    using Service.Interfaces;

    [RouteArea("Admin")]
    [RoutePrefix("Coach")]
    [MyAuthorize(Roles = "Admin")]
    [HandleError]
    public class CoachController : Controller
    {
        private ICoachService service;

        public CoachController(ICoachService service)
        {
            this.service = service;
        }

        [Route("AllCoaches")]
        public ActionResult AllCoaches()
        {
            IEnumerable<CoachVm> model = service.GetAllCoaches();
            return View(model.ToList());
        }

        // GET: Admin/PlaayersVms/Create
        [Route("AddCoach")]
        public ActionResult AddCoach()
        {
            return View();
        }


        [Route("AddCoach")]
        [HttpPost]
        public ActionResult AddCoach(CoachVm model)
        {
           
            if (ModelState.IsValid)
            {
                service.AddCoach(model);
                RedirectToAction("AllCoaches");
            }

            return this.View(model);
        }

        [HttpGet]
        [Route("EditCoach")]
        public ActionResult EditCoach(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoachVm coachVm = service.EditCoach(id);
            if (coachVm == null)
            {
                return HttpNotFound();
            }
            return View(coachVm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("EditCoach")]
        public ActionResult EditCoach([Bind(Include = "Id,FirstName,LastName,CoachYears,Description,ImageUrl,VideoUrl,Nationality")] CoachVm coachVm)
        {
            if (ModelState.IsValid)
            {
                service.Edit(coachVm);
                return RedirectToAction("AllCoaches");
            }
            return View(coachVm);
        }

        [Route("Delete")]
        public ActionResult DeleteCoach(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoachVm coachVm = service.DeleteCoach(id);
            if (coachVm == null)
            {
                return HttpNotFound();
            }
            return View(coachVm);
        }

        // POST: BlogArticleBms/Delete/5
        [HttpPost, ActionName("DeleteCoach")]
        [ValidateAntiForgeryToken]
        [Route("DeleteCoach")]
        public ActionResult DeleteConfirmed(int? id)
        {

            service.Delete(id);
            return RedirectToAction("AllCoaches");
        }
    }
}
