namespace FClubBarcelona.Service.Interfaces
{
    using System.Collections.Generic;
    using Models.BindingModels.Blog;

    public interface IBlogService
    {
        void AddArticle(BlogArticleBm model, string user);
        void Delete(int? id);
        BlogArticleBm DeleteArticle(int? id);
        void Edit(BlogArticleBm blogArticleBm);
        BlogArticleBm EditArticle(int? id);
        IEnumerable<BlogArticleBm> GetAllArticles();
    }
}