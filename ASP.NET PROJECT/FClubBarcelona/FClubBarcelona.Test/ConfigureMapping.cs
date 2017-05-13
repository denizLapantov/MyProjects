using AutoMapper;
using FClubBarcelona.Models.BindingModels.Blog;
using FClubBarcelona.Models.BindingModels.Message;
using FClubBarcelona.Models.BindingModels.Players;
using FClubBarcelona.Models.IdentityModels;
using FClubBarcelona.Models.ViewModels.Blog;
using FClubBarcelona.Models.ViewModels.Coaches;
using FClubBarcelona.Models.ViewModels.Galery;
using FClubBarcelona.Models.ViewModels.Home;
using FClubBarcelona.Models.ViewModels.MessagesFromUsers;
using FClubBarcelona.Models.ViewModels.Players;
using FClubBarcelona.Models.ViewModels.Video;

namespace FClubBarcelona.Test
{
    public class ConfigureMapping
    {

        public void ConfigureMaping()
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<Player, PlayerViewModel>();
                expression.CreateMap<Article, ArticleViewModel>();
                expression.CreateMap<Player, DetailsPlayersVm>();
                expression.CreateMap<BlogArticleBm, Article>();
                expression.CreateMap<Article, BlogArticleBm>();
                expression.CreateMap<Player, PlaayersVm>();
                expression.CreateMap<PlayersBm, Player>();
                expression.CreateMap<Player, PlayersBm>();
                expression.CreateMap<ApplicationUser, Article>();
                expression.CreateMap<Article, ApplicationUser>();
                expression.CreateMap<Article, ArticleDetailsVm>();
                expression.CreateMap<ApplicationUser, ArticleDetailsVm>();
                expression.CreateMap<ArticleDetailsVm, ApplicationUser>();
                expression.CreateMap<MessageFromUserBm, MessageFromUser>();
                expression.CreateMap<Galery, GaleryViewModel>();
                expression.CreateMap<GaleryViewModel, Galery>();
                expression.CreateMap<Coach, AllCoachesVm>();
                expression.CreateMap<Coach, CoachDetailsVm>();
                expression.CreateMap<Video, VideoVm>();
                expression.CreateMap<Coach, CoachVm>();
                expression.CreateMap<CoachVm, Coach>();
                expression.CreateMap<VideoVm, Video>();
                expression.CreateMap<MessageFromUser, AllMessagesFromUsers>();
                expression.CreateMap<AllMessagesFromUsers, MessageFromUser>();
                expression.CreateMap<ApplicationUser, BlogArticleBm>();
                expression.CreateMap<BlogArticleBm, ApplicationUser>();
            });
        }
    }
}
