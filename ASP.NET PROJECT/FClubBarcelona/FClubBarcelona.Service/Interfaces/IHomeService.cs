namespace FClubBarcelona.Service.Interfaces
{
    using System.Collections.Generic;
    using Models.BindingModels.Message;
    using Models.ViewModels.Blog;
    using Models.ViewModels.Coaches;
    using Models.ViewModels.Galery;
    using Models.ViewModels.Home;
    using Models.ViewModels.Video;

    public interface IHomeService
    {
        IEnumerable<ArticleViewModel> GetAllArticles();
        IEnumerable<AllCoachesVm> GetAllCoaches();
        IEnumerable<GaleryViewModel> GetAllPhotos();
        IEnumerable<VideoVm> GetAllVideos();
        DetailsPlayersVm GetDetails(string lastName);
        ArticleDetailsVm GetDetailsArticle(string title);
        CoachDetailsVm GetDetailsCoach(string lastName);
        IEnumerable<PlayerViewModel> GettAllPlayers();
        IEnumerable<PlayerViewModel> SearchPlayers(string query);
        IEnumerable<VideoVm> SearchVideo(string query);
        void SendMessage(string user, MessageFromUserBm model);
    }
}