namespace FClubBarcelona.Areas.Admin.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using Attributes;
    using FClubBarcelona.Controllers;
    using Data;
    using Models.ViewModels.Account;
    using Models.ViewModels.MessagesFromUsers;
    using Service;
    using Service.Interfaces;


    [RouteArea("Admin")]
    [RoutePrefix("Admin")]
    [MyAuthorize(Roles = "Admin")]
    [HandleError]
    public class AdminController : Controller
    {

        private IAccountService service;

        public AdminController(IAccountService service)
        {
            this.service = service;
        }

        [Authorize(Roles = "Admin")]
        [Route("AllUsers")]
        public ActionResult AllUsers()
        {
            var Db = new FClubBarcelonaContext();
            var users = Db.Users;
            var model = new List<EditUserViewModel>();
            foreach (var user in users)
            {
                var u = new EditUserViewModel(user);
                model.Add(u);
            }
            return View(model);
        }


        [Authorize(Roles = "Admin")]
        [Route("EditUsers")]
        public ActionResult EditUsers(string id, AccountController.ManageMessageId? Message = null)
        {
            var Db = new FClubBarcelonaContext();
            var user = Db.Users.First(u => u.UserName == id);
            var model = new EditUserViewModel(user);
            ViewBag.MessageId = Message;
            return View(model);
        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        [Route("EditUsers")]
        public async Task<ActionResult> EditUsers(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var Db = new FClubBarcelonaContext();
                var user = Db.Users.First(u => u.UserName == model.UserName);
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Email = model.Email;
                Db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                await Db.SaveChangesAsync();
                return RedirectToAction("AllUsers");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }


        [Authorize(Roles = "Admin")]
        [Route("DeleteUser")]
        public ActionResult DeleteUser(string id = null)
        {
            var Db = new FClubBarcelonaContext();
            var user = Db.Users.First(u => u.UserName == id);
            var model = new EditUserViewModel(user);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }


        [HttpPost, ActionName("DeleteUser")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        [Route("DeleteUser")]
        public ActionResult DeleteConfirmed(string id)
        {
            var Db = new FClubBarcelonaContext();
            var user = Db.Users.First(u => u.UserName == id);
            Db.Users.Remove(user);
            Db.SaveChanges();
            return RedirectToAction("AllUsers");
        }


        [Authorize(Roles = "Admin")]
        [Route("UserRoles")]
        public ActionResult UserRoles(string id)
        {
            var Db = new FClubBarcelonaContext();
            var user = Db.Users.First(u => u.UserName == id);
            var model = new RoleService(user);
            return View(model);
        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        [Route("UserRoles")]
        public ActionResult UserRoles(RoleService model)
        {
            if (ModelState.IsValid)
            {
                var idManager = new AccountService();
                var Db = new FClubBarcelonaContext();
                var user = Db.Users.First(u => u.UserName == model.UserName);
                idManager.ClearUserRoles(user.Id);

                foreach (var role in model.Roles)
                {
                    if (role.Selected)
                    {
                        idManager.AddUserToRole(user.Id, role.RoleName);
                    }
                }
                return RedirectToAction("AllUsers");
            }
            return View();
        }

        [Route("AllMessagesFromUsers")]
        public ActionResult AllMessagesFromUsers()
        {
            var user = User.Identity.Name;
            IEnumerable<AllMessagesFromUsers> model = service.GetAllMessages(user);
            return View(model);
        }

        [Route("DeleteMessage")]
        public ActionResult DeleteMessage(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AllMessagesFromUsers allMessages = service.DeleteMessage(id);
            if (allMessages == null)
            {
                return HttpNotFound();
            }
            return View(allMessages);
        }

        // POST: BlogArticleBms/Delete/5
        [HttpPost, ActionName("DeleteMessage")]
        [ValidateAntiForgeryToken]
        [Route("DeleteMessage")]
        public ActionResult DeleteConfirmed(int? id)
        {

            service.Delete(id);
            return RedirectToAction("AllMessagesFromUsers");
        }

        [Route("Home")]
        public ActionResult Home()
        {
            return View();
        }
    }
}