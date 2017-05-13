namespace FClubBarcelona.Service
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Models.BindingModels.Message;
    using Models.IdentityModels;
    using Models.ViewModels.Blog;
    using Models.ViewModels.Coaches;
    using Models.ViewModels.Galery;
    using Models.ViewModels.Home;
    using Models.ViewModels.Video;
    using Interfaces;

    public class HomeService : Service, IHomeService
    {
        public IEnumerable<PlayerViewModel> GettAllPlayers()
        {
            IEnumerable<Player> players = Context.Players;
            IEnumerable<PlayerViewModel> model = Mapper.Map<IEnumerable<Player>, IEnumerable<PlayerViewModel>>(players);
            return model;
        }

        public DetailsPlayersVm GetDetails(string lastName)
        {
            Player player = Context.Players.FirstOrDefault(x=>x.LastName == lastName);

            DetailsPlayersVm model = Mapper.Map<Player, DetailsPlayersVm>(player);
            return model;
        }

        public IEnumerable<ArticleViewModel> GetAllArticles()
        {
            IEnumerable<Article> articles = Context.Articles;
            IEnumerable<ArticleViewModel> model =
                Mapper.Map<IEnumerable<Article>, IEnumerable<ArticleViewModel>>(articles);
            return model;
        }

        public ArticleDetailsVm GetDetailsArticle(string title)
        {
            Article article = Context.Articles.FirstOrDefault(x => x.Title == title);

            ArticleDetailsVm model = Mapper.Map<Article, ArticleDetailsVm>(article);
            model.Autor = article.Author.FirstName + " " + article.Author.LastName;
            return model;
        }

        public void SendMessage(string user, MessageFromUserBm model)
        {
            ApplicationUser currentuser = Context.Users.FirstOrDefault(x => x.FirstName.ToLower() == user.ToLower());
            MessageFromUser m = Mapper.Map<MessageFromUserBm, MessageFromUser>(model);
            m.Sender = currentuser;
            Context.MessagesFromUsers.Add(m);
            Context.SaveChanges();
        }

        public IEnumerable<GaleryViewModel> GetAllPhotos()
        {
            IEnumerable<Galery> galeries = Context.Galeries;
            IEnumerable<GaleryViewModel> model = Mapper.Map<IEnumerable<Galery>, IEnumerable<GaleryViewModel>>(galeries);
            return model;
        }

        public IEnumerable<AllCoachesVm> GetAllCoaches()
        {
            IEnumerable<Coach> coaches = Context.Coaches;
            IEnumerable<AllCoachesVm> model = Mapper.Map<IEnumerable<Coach>, IEnumerable<AllCoachesVm>>(coaches);
            return model;
        }

        public CoachDetailsVm GetDetailsCoach(string lastName)
        {
            Coach coach = Context.Coaches.FirstOrDefault(x => x.LastName == lastName);

            CoachDetailsVm model = Mapper.Map<Coach, CoachDetailsVm>(coach);
            return model;
        }

        public IEnumerable<VideoVm> GetAllVideos()
        {
            IEnumerable<Video> videos = Context.Videos;
            IEnumerable<VideoVm> model = Mapper.Map<IEnumerable<Video>, IEnumerable<VideoVm>>(videos);
            return model;
        }

      
        public IEnumerable<PlayerViewModel> SearchPlayers(string query)
        {
            IEnumerable<Player> players = Context.Players;
            IEnumerable<PlayerViewModel> model = Mapper.Map<IEnumerable<Player>, IEnumerable<PlayerViewModel>>(players);
            return model.Where(x => x.LastName.ToLower().Contains(query.ToLower())).ToList();
        }

        public IEnumerable<VideoVm> SearchVideo(string query)
        {
            IEnumerable<Video> videos = Context.Videos;
            IEnumerable<VideoVm> model = Mapper.Map<IEnumerable<Video>, IEnumerable<VideoVm>>(videos);
            return model.Where(x => x.Title.ToLower().Contains(query.ToLower())).ToList();
        }
    }
}
