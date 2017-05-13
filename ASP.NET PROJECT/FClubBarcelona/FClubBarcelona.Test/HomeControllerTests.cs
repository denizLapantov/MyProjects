namespace FClubBarcelona.Test
{
    using System.Collections.Generic;
    using Controllers;
    using Models.ViewModels.Blog;
    using Models.ViewModels.Coaches;
    using Models.ViewModels.Galery;
    using Models.ViewModels.Home;
    using Models.ViewModels.Video;
    using Service;
    using Service.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestStack.FluentMVCTesting;

    [TestClass]
    public class HomeControllerTests
    {
        private IHomeService service;
        private HomeController controller;
        private ConfigureMapping mapping;

        [TestInitialize]
        public void Init()
        {
            service = new HomeService();
            controller = new HomeController(service);
            mapping = new ConfigureMapping();
            mapping.ConfigureMaping();
          
        }
        [TestMethod]
        public void IndexActionShouldRenderViewAction()
        {
            controller.WithCallTo(x => x.Index()).ShouldRenderView("Index");
        }
            
        [TestMethod]
        public void IndexActionShouldRenderDefaultView()
        {   
            controller.WithCallTo(x => x.Index()).ShouldRenderDefaultView();
        }


        [TestMethod]
        public void PlayersActionShouldRenderViewPlayers()
        {

            controller.WithCallTo(x => x.Players()).ShouldRenderView("Players").WithModel<IEnumerable<PlayerViewModel>>();
        }

        [TestMethod]
        public void PlayersActionShouldRenderDefaultView()
        {

            controller.WithCallTo(x => x.Players()).ShouldRenderDefaultView().WithModel<IEnumerable<PlayerViewModel>>();
        }

        [TestMethod]
        public void ArticlesActionShouldRenderViewArticles()
        {

            controller.WithCallTo(x => x.Articles()).ShouldRenderView("Articles").WithModel<IEnumerable<ArticleViewModel>>();
        }

        [TestMethod]
        public void ArticlesActionShouldRenderDefaultView()
        {

            controller.WithCallTo(x => x.Articles()).ShouldRenderDefaultView().WithModel<IEnumerable<ArticleViewModel>>();
        }

        [TestMethod]
        public void CoachesActionShouldRenderViewCoaches()
        {

            controller.WithCallTo(x => x.Coaches()).ShouldRenderView("Coaches").WithModel<IEnumerable<AllCoachesVm>>();
        }

        [TestMethod]
        public void CoachesActionShouldRenderDefaultView()
        {

            controller.WithCallTo(x => x.Coaches()).ShouldRenderDefaultView().WithModel<IEnumerable<AllCoachesVm>>();
        }

        [TestMethod] public void GaleryActionShouldRenderViewGalery()
        {

            controller.WithCallTo(x => x.Galery()).ShouldRenderView("Galery").WithModel<IEnumerable<GaleryViewModel>>();
        }

        [TestMethod]
        public void GaleryActionShouldRenderDefaultView()
        {

            controller.WithCallTo(x => x.Galery()).ShouldRenderDefaultView().WithModel<IEnumerable<GaleryViewModel>>();
        }

        [TestMethod]
        public void VideoActionShouldRenderViewVideo()
        {

            controller.WithCallTo(x => x.Video()).ShouldRenderView("Video").WithModel<IEnumerable<VideoVm>>();
        }

        [TestMethod]
        public void VideoActionShouldRenderDefaultView()
        {

            controller.WithCallTo(x => x.Video()).ShouldRenderDefaultView().WithModel<IEnumerable<VideoVm>>();
        }

        [TestMethod]
        public void ContactActionShouldRenderViewContact()
        {   

            controller.WithCallTo(x => x.Contact()).ShouldRenderView("Contact");
        }

        [TestMethod]
        public void ContactActionShouldRenderDefaultView()
        {

            controller.WithCallTo(x => x.Contact()).ShouldRenderDefaultView();
        }

        [TestMethod]
        public void ClubRecordsActionShouldRenderClubRecords()
        {

            controller.WithCallTo(x => x.ClubRecords()).ShouldRenderView("ClubRecords");
        }

        [TestMethod]
        public void ClubRecordsActionShouldRenderDefaultView()
        {

            controller.WithCallTo(x => x.ClubRecords()).ShouldRenderDefaultView();
        }

        [TestMethod]
        public void DownloadActionShouldRenderDownload()
        {

            controller.WithCallTo(x => x.Download()).ShouldRenderView("Download");
        }

        [TestMethod]
        public void DownloadActionShouldRenderDefaultView()
        {

            controller.WithCallTo(x => x.Download()).ShouldRenderDefaultView();
        }

        [TestMethod]
        public void DownloadHymnActionShouldRenderDownloadHymn()
        {

            controller.WithCallTo(x => x.DownloadHymn()).ShouldRenderView("DownloadHymn");
        }

        [TestMethod]
        public void DownloadHymnActionShouldRenderDefaultView()
        {

            controller.WithCallTo(x => x.DownloadHymn()).ShouldRenderDefaultView();
        }

        [TestMethod]
        public void ErrorActionShouldRenderError()
        {

            controller.WithCallTo(x => x.Error()).ShouldRenderView("Error");
        }

        [TestMethod]
        public void ErrorActionShouldRenderDefaultView()
        {

            controller.WithCallTo(x => x.Error()).ShouldRenderDefaultView();
        }

        [TestMethod]
        public void PlayersDetailsrActionShouldRenderDefaultView()
        {
            string lastName = "Messi";
            controller.WithCallTo(x => x.DetailsPlayer(lastName)).ShouldRenderDefaultView().WithModel<DetailsPlayersVm>();
        }

        [TestMethod]
        public void PlayersDetailsrActionShouldRenderDetailsPlayer()
        {
            string lastName = "Messi";
            controller.WithCallTo(x => x.DetailsPlayer(lastName)).ShouldRenderView("DetailsPlayer").WithModel<DetailsPlayersVm>();
        }

        [TestMethod]
        public void CoachesDetailsActionShouldRenderDefaultView()
        {
            string lastName = "Enrique";
            controller.WithCallTo(x => x.CoachesDetails(lastName)).ShouldRenderDefaultView().WithModel<CoachDetailsVm>();
        }

        [TestMethod]
        public void CoachesDetailsActionShouldRenderCoachesDetails()
        {
            string lastName = "Enrique";
            controller.WithCallTo(x => x.CoachesDetails(lastName)).ShouldRenderView("CoachesDetails").WithModel<CoachDetailsVm>();
        }

        [TestMethod]
        public void SearchVideoActionShouldRenderSertVideosPartialView()
        {
            string query = "Messi";
            controller.WithCallTo(x => x.SearchVideo(query)).ShouldRenderPartialView("SortVideos").WithModel<IEnumerable<VideoVm>>();
        }


        [TestMethod]
        public void SearchActionShouldRenderPartialViewSortPlayers()
        {
            string query = "Messi";
            controller.WithCallTo(x => x.Search(query)).ShouldRenderPartialView("SortPlayers").WithModel<IEnumerable<PlayerViewModel>>();
        }

    }
}