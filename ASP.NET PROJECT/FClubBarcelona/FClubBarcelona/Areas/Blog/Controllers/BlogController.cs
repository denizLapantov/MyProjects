namespace FClubBarcelona.Areas.Blog.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Web.Mvc;
    using Attributes;
    using Models.BindingModels.Blog;
    using Service.Interfaces;

    [RouteArea("blog")]
    [RoutePrefix("blog")]
    [MyAuthorize(Roles = "Admin, BlogAuthor")]
    [HandleError]
    public class BlogController : Controller
    {
        private IBlogService service;

        public BlogController(IBlogService service)
        {
            this.service =  service;
        }
        [Route("AllArticles")]
        public ActionResult AllArticles()
        {
            IEnumerable<BlogArticleBm> model = service.GetAllArticles();
            return View(model.ToList());
        }

        [Route("AddArticle")]
        public ActionResult AddArticle()
        {
            return View();
        }



        [Route("AddArticle")]
        [HttpPost]
        public ActionResult AddArticle(BlogArticleBm model)
        {
            var user = User.Identity.Name;

            if (ModelState.IsValid)
            {
                service.AddArticle(model, user);
                RedirectToAction("AllArticles");
            }

            return this.View(model);
        }

      
        [HttpGet]
        [Route("Edit")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogArticleBm blogArticleBm = service.EditArticle(id);
            if (blogArticleBm == null)
            {
                return HttpNotFound();
            }
            return View(blogArticleBm);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Edit")]
        public ActionResult Edit([Bind(Include = "Id,Title,Content,StartArticle,ImageTitle,YouTubeUrl")] BlogArticleBm blogArticleBm)
        {
            if (ModelState.IsValid)
            {
                service.Edit(blogArticleBm);           
                return RedirectToAction("AllArticles");
            }
            return View(blogArticleBm);
        }

        // GET: BlogArticleBms/Delete/5
        [Route("Delete")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogArticleBm blogArticleBm = service.DeleteArticle(id);
            if (blogArticleBm == null)
            {
                return HttpNotFound();
            }
            return View(blogArticleBm);
        }

        // POST: BlogArticleBms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {

            service.Delete(id);
            return RedirectToAction("AllArticles");
        }

        [Route("Home")]
        public ActionResult Home()
        {
            return View();
        }
      
        


    }
}

