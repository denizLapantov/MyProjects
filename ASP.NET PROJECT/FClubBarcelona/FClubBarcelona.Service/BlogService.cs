namespace FClubBarcelona.Service
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using AutoMapper;
    using Models.BindingModels.Blog;
    using Models.IdentityModels;
    using Interfaces;

    public class BlogService : Service, IBlogService
    {
        public void AddArticle(BlogArticleBm model, string user)
        {
            var userName = Context.Users.FirstOrDefault(x => x.UserName == user);
            Article modelVm = Mapper.Map<BlogArticleBm, Article>(model);
            modelVm.Author = userName;
            modelVm.PublishDate = DateTime.Today;
            Context.Articles.Add(modelVm);
            Context.SaveChanges();
        }

        public IEnumerable<BlogArticleBm> GetAllArticles()
        {
            IEnumerable<Article> articles = Context.Articles;
            IEnumerable<BlogArticleBm> model = Mapper.Map<IEnumerable<Article>, IEnumerable<BlogArticleBm>>(articles);
            return model;
        }

        public BlogArticleBm EditArticle(int? id)
        {
            Article article = Context.Articles.Find(id);
            BlogArticleBm model = Mapper.Map<Article, BlogArticleBm>(article);
            return model;
        }

        public void Edit(BlogArticleBm blogArticleBm)
        {
            Article article = Mapper.Map<BlogArticleBm, Article>(blogArticleBm);
            article.PublishDate = DateTime.Today;

            Context.Entry(article).State = EntityState.Modified;

            Context.SaveChanges();
        }

        public BlogArticleBm DeleteArticle(int? id)
        {
            Article article = Context.Articles.Find(id);
            BlogArticleBm model = Mapper.Map<Article, BlogArticleBm>(article);
            return model;
        }

        public void Delete(int? id)
        {
            Article entityToDelete = Context.Articles.Find(id);
            Context.Articles.Remove(entityToDelete);
            Context.SaveChanges();
        }
    }
}
