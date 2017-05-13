namespace FClubBarcelona
{
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using AutoMapper;
    using Models.BindingModels.Blog;
    using Models.BindingModels.Message;
    using Models.BindingModels.Players;
    using Models.IdentityModels;
    using Models.ViewModels.Blog;
    using Models.ViewModels.Coaches;
    using Models.ViewModels.Galery;
    using Models.ViewModels.Home;
    using Models.ViewModels.MessagesFromUsers;
    using Models.ViewModels.Players;
    using Models.ViewModels.Video;

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ConfigureMapping();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void ConfigureMapping()
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<Player, PlayerViewModel>();
                expression.CreateMap<Article, ArticleViewModel>();
                expression.CreateMap<Player, DetailsPlayersVm>();
                expression.CreateMap< BlogArticleBm, Article>();
                expression.CreateMap<Article, BlogArticleBm>();
                expression.CreateMap<Player, PlaayersVm>();
                expression.CreateMap<PlayersBm, Player>();
                expression.CreateMap<Player, PlayersBm>();
                expression.CreateMap<ApplicationUser, Article>();
                expression.CreateMap<Article, ApplicationUser>();
                expression.CreateMap<Article, ArticleDetailsVm>();
                expression.CreateMap<ApplicationUser,ArticleDetailsVm>();
                expression.CreateMap<ArticleDetailsVm, ApplicationUser>();
                expression.CreateMap<MessageFromUserBm, MessageFromUser>();
                expression.CreateMap<Galery, GaleryViewModel>();
                expression.CreateMap<GaleryViewModel,Galery>();
                expression.CreateMap<Coach, AllCoachesVm>();
                expression.CreateMap<Coach, CoachDetailsVm>();
                expression.CreateMap<Video, VideoVm>();
                expression.CreateMap<Coach, CoachVm>();
                expression.CreateMap<CoachVm,Coach>();
                expression.CreateMap<VideoVm,Video>();
                expression.CreateMap<MessageFromUser, AllMessagesFromUsers>();
                expression.CreateMap<AllMessagesFromUsers, MessageFromUser>();
                expression.CreateMap<ApplicationUser, BlogArticleBm>();
                expression.CreateMap<BlogArticleBm, ApplicationUser>();
            });

        }
    }
}