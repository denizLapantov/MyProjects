namespace FClubBarcelona.Test
{
    using System.Collections.Generic;
    using Areas.Admin.Controllers;
    using Models.ViewModels.Galery;
    using Models.ViewModels.Video;
    using Service;
    using Service.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestStack.FluentMVCTesting;

    [TestClass]
    public class GaleryControllerTests
    {
        private GaleryController controller;
        private IGaleryService service;
        private ConfigureMapping mapping;


        public GaleryControllerTests()
        {
            service = new GaleryService();
            controller = new GaleryController(service);
            mapping = new ConfigureMapping();
            mapping.ConfigureMaping();
        }

        [TestMethod]
        public void AllPicturesActionShouldRenderViewAllPictures()
        {
            controller.WithCallTo(x => x.AllPictures())
                .ShouldRenderDefaultView()
                .WithModel<IEnumerable<GaleryViewModel>>();
        }

        [TestMethod]
        public void AllPicturesActionShouldRenderDefaultView()
        {
            controller.WithCallTo(x => x.AllPictures())
                .ShouldRenderView("AllPictures")
                .WithModel<IEnumerable<GaleryViewModel>>();
        }


        [TestMethod]
        public void AllVideosActionShouldRenderViewAllAllVideos()
        {
            controller.WithCallTo(x => x.AllVideos())
                .ShouldRenderDefaultView()
                .WithModel<IEnumerable<VideoVm>>();
        }

        [TestMethod]
        public void AllVideosActionShouldRenderDefaultView()
        {
            controller.WithCallTo(x => x.AllVideos())
                .ShouldRenderView("AllVideos")
                .WithModel<IEnumerable<VideoVm>>();
        }

        [TestMethod]
        public void UploadActionShouldRenderViewUpload()
        {
            controller.WithCallTo(x => x.Upload())
                .ShouldRenderDefaultView();

        }

        [TestMethod]
        public void UploadActionShouldRenderDefaultView()
        {
            controller.WithCallTo(x => x.Upload())
                .ShouldRenderView("Upload");

        }

        [TestMethod]
        public void AddVideoActionShouldRenderViewAddVideo()
        {
            controller.WithCallTo(x => x.AddVideo())
                .ShouldRenderDefaultView();

        }

        [TestMethod]
        public void AddVideoActionShouldRenderDefaultView()
        {
            controller.WithCallTo(x => x.AddVideo())
                .ShouldRenderView("AddVideo");

        }

        [TestMethod]
        public void AddPicturesActionShouldRenderViewAddPicture()
        {
            controller.WithCallTo(x => x.AddPicture())
                .ShouldRenderDefaultView();

        }

        [TestMethod]
        public void AddVPictureActionShouldRenderDefaultView()
        {
            controller.WithCallTo(x => x.AddPicture())
                .ShouldRenderView("AddPicture");
        }
    }
}