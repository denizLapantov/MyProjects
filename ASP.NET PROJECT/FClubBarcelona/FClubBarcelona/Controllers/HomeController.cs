namespace FClubBarcelona.Controllers
{
    using System.Collections.Generic;
    using System.IO;
    using System.Web;
    using System.Web.Mvc;
    using Models.BindingModels.Message;
    using Models.ViewModels.Blog;
    using Models.ViewModels.Coaches;
    using Models.ViewModels.Galery;
    using Models.ViewModels.Home;
    using Models.ViewModels.Video;
    using Service.Interfaces;

    [HandleError]
    public class HomeController : Controller
    {
        private IHomeService service;

        public HomeController(IHomeService service)
        {
            this.service = service;
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("Players")]
        public ActionResult Players()
        {
            IEnumerable<PlayerViewModel> model = service.GettAllPlayers();
            return View(model);
        }


        [Route("DetailsPlayer/{lastName}")]
        [HttpGet]
        public ActionResult DetailsPlayer(string lastName)
        {
            DetailsPlayersVm model = service.GetDetails(lastName);
            return View(model);
        }

        [Route("DetailsArticle/{title}")]
        [HttpGet]
        public ActionResult DetailsArticle(string title)
        {
            ArticleDetailsVm model = service.GetDetailsArticle(title);
            return View(model);
        }

        [Route("Articles")]
        public ActionResult Articles()
        {
            IEnumerable<ArticleViewModel> model = service.GetAllArticles();
            return View(model);
        }

        [HttpPost]
        [Route("MessageFromUser")]
        public ActionResult MessageFromUser(MessageFromUserBm model)
        {

            string user = User.Identity.Name;
            service.SendMessage(user, model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("History")]
        public ActionResult History()
        {
            return View();
        }

        [Route("Galery")]
        public ActionResult Galery()
        {
            IEnumerable<GaleryViewModel> model = service.GetAllPhotos();
            return View(model);
        }

        [Route("Coaches")]
        public ActionResult Coaches()
        {
            IEnumerable<AllCoachesVm> model = service.GetAllCoaches();
            return View(model);
        }


        [Route("Coaches/{lastName}")]
        [HttpGet]
        public ActionResult CoachesDetails(string lastName)
        {
            CoachDetailsVm model = service.GetDetailsCoach(lastName);
            return View(model);
        }

        [Route("Video")]
        public ActionResult Video()
        {
            IEnumerable<VideoVm> model = service.GetAllVideos();
            return View(model);
        }

        [HttpGet]
        [Route("DownloadHymn")]
        public ActionResult DownloadHymn()
        {
            return View();
        }


        [HttpGet]
        [Route("DownloadPictures")]
        [Authorize]
        public ActionResult DownloadPictures()
        {
            string[] files = Directory.GetFiles(Server.MapPath("/Content/MyTemplete/Download/Photos/"));
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = Path.GetFileName(files[i]);
            }
            ViewBag.Files = files;
            return View();
        }

        [HttpGet]
        [Authorize]
        [Route("BarcelonaHymn")]
        [ActionName("BarcelonaHymn")]
        public ActionResult MyAudio()
        {
            var file = Server.MapPath("~/Content/MyTemplete/Download/Fc Barselona - Himno Del Fc Barcelona.mp3");
            return File(file, "audio/mp3");
        }

        [Route("Error")]
        public ActionResult Error()
        {
            return View("Error");
        }


        [Route("Search")]
        public ActionResult Search(string query)
        {
            IEnumerable<PlayerViewModel> model = service.SearchPlayers(query);
            return PartialView("SortPlayers", model);
        }

        [Route("Download")]
        [Authorize]
        public ActionResult Download()
        {
            return View();
        }

        public FileResult DownloadFile(string fileName)
        {
            var filepath = Path.Combine(Server.MapPath("/Content/MyTemplete/Download/Photos/"), fileName);
            return File(filepath, MimeMapping.GetMimeMapping(filepath), fileName);
        }


        [Route("ClubRecords")]
        public ActionResult ClubRecords()
        {
            return View();
        }

        [Route("SearchVideo")]
        public ActionResult SearchVideo(string query)
        {
            IEnumerable<VideoVm> model = service.SearchVideo(query);
            return PartialView("SortVideos", model);
        }
    }

}
