namespace FClubBarcelona.Test
{
    using System.Collections.Generic;
    using Areas.Blog.Controllers;
    using Models.BindingModels.Blog;
    using Service;
    using Service.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestStack.FluentMVCTesting;

    [TestClass]
    public class BlogControllerTests
    {
        private BlogController controller;
        private IBlogService service;
        private ConfigureMapping mapping;


        public BlogControllerTests()
        {
            service = new BlogService();
            controller = new BlogController(service);
            mapping = new ConfigureMapping();
            mapping.ConfigureMaping();
        }

        [TestMethod]
        public void AllArticlesActionShouldRenderViewAllArticles()
        {
            controller.WithCallTo(x => x.AllArticles())
                .ShouldRenderDefaultView()
                .WithModel<IEnumerable<BlogArticleBm>>();
        }

        [TestMethod]
        public void AllArticlesActionShouldRenderDefaultView()
        {
            controller.WithCallTo(x => x.AllArticles())
                .ShouldRenderView("AllArticles")
                .WithModel<IEnumerable<BlogArticleBm>>();
        }

        [TestMethod]
        public void AddArticleActionShouldRenderViewAddArticles()
        {
            controller.WithCallTo(x => x.AddArticle())
                .ShouldRenderDefaultView();

        }

        [TestMethod]
        public void AddArticleActionShouldRenderDefaultView()
        {
            controller.WithCallTo(x => x.AddArticle())
                .ShouldRenderView("AddArticle");
        }
    }
}
