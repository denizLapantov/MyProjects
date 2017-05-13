namespace FClubBarcelona.Areas.Admin.Controllers
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Mvc;
    using Attributes;
    using Models.ViewModels.Galery;
    using Models.ViewModels.Video;
    using Service.Interfaces;

    [RouteArea("Admin")]
    [RoutePrefix("Galery")]
    [MyAuthorize(Roles = "Admin")]
    [HandleError]
    public class GaleryController : Controller
    {
        private IGaleryService service;

        public GaleryController(IGaleryService service)
        {
            this.service = service;
        }

        [Route("AllPictures")]
        public ActionResult AllPictures()
        {
            IEnumerable<GaleryViewModel> model = service.GetAllPictures();
            return View(model.ToList());
        }

        [Route("AddPicture")]
        public ActionResult AddPicture()
        {
            return View();
        }


        [Route("AddPicture")]
        [HttpPost]
        public ActionResult AddPicture(GaleryViewModel model)
        {

            if (ModelState.IsValid)
            {
                service.AddPIcture(model);
                RedirectToAction("AllPictures");
            }

            return this.View(model);
        }

        [HttpGet]
        [Route("EditPicture")]
        public ActionResult EditPicture(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GaleryViewModel picture = service.EditPicture(id);
            if (picture == null)
            {
                return HttpNotFound();
            }
            return View(picture);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("EditPicture")]
        public ActionResult EditPicture([Bind(Include = "Id,ImageTitle,ImageUrl")] GaleryViewModel pictureVm)
        {
            if (ModelState.IsValid)
            {
                service.EditPic(pictureVm);
                return RedirectToAction("AllPictures");
            }
            return View(pictureVm);
        }

        [Route("DeletePicture")]
        public ActionResult DeletePicture(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GaleryViewModel galeryViewModel = service.DeletePicture(id);
            if (galeryViewModel == null)
            {
                return HttpNotFound();
            }
            return View(galeryViewModel);
        }

        // POST: BlogArticleBms/Delete/5
        [HttpPost, ActionName("DeletePicture")]
        [ValidateAntiForgeryToken]
        [Route("DeletePicture")]
        public ActionResult DeleteConfirmed(int? id)
        {

            service.Delete(id);
            return RedirectToAction("AllPictures");
        }

        [Route("AllVideos")]
        public ActionResult AllVideos()
        {
            IEnumerable<VideoVm> model = service.GetAllVideos();
            return View(model.ToList());
        }

        [Route("AddVideo")]
        public ActionResult AddVideo()
        {
            return View();
        }


        [Route("AddVideo")]
        [HttpPost]
        public ActionResult AddVideo(VideoVm model)
        {

            if (ModelState.IsValid)
            {
                service.AddVideo(model);
                RedirectToAction("AllVideos");
            }

            return this.View(model);
        }

        [HttpGet]
        [Route("EditVideo")]
        public ActionResult EditVideo(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoVm picture = service.EditVideo(id);
            if (picture == null)
            {
                return HttpNotFound();
            }
            return View(picture);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("EditVideo")]
        public ActionResult EditVideo([Bind(Include = "Id,Title,VideoUrl,Duration")] VideoVm videoVm)
        {
            if (ModelState.IsValid)
            {
                service.EditVid(videoVm);
                return RedirectToAction("AllVideos");
            }
            return View(videoVm);
        }

        [Route("DeleteVideo")]
        public ActionResult DeleteVideo(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoVm videoVm = service.DeleteVideo(id);
            if (videoVm == null)
            {
                return HttpNotFound();
            }
            return View(videoVm);
        }

        // POST: BlogArticleBms/Delete/5
        [HttpPost, ActionName("DeleteVideo")]
        [ValidateAntiForgeryToken]
        [Route("DeleteVideo")]
        public ActionResult Delete(int? id)
        {

            service.DeleteVid(id);
            return RedirectToAction("AllVideos");
        }

        [HttpGet]
        [Route("Upload")]
        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        [Route("Upload")]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/MyTemplete/Download/Photos"), fileName);
                file.SaveAs(path);
            }

            return RedirectToAction("Upload");
        }

    }
}
