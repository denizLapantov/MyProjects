namespace FClubBarcelona.Data
{
    using Contracts;
    using Repositories;
    using Models.IdentityModels;

    public class FClubBarcelonaData : IFClubBarcelonaData
    {
        private readonly IFClubBarcelonaContext context;
    
        public FClubBarcelonaData(IFClubBarcelonaContext context)
        {   
            this.context = context;
        }
        public Repository<ApplicationUser> Users { get; set; }
        public Repository<Video> VideoRepository { get; set; }
        public Repository<Galery> GaleryRepository { get; set; }
        public Repository<Article> ArticleRepository { get; set; }
        public Repository<MessageFromUser> MessageRepository { get; set; }
        public Repository<Player> PlayerRepository { get; set; }
        public Repository<Coach> CoachRepository { get; set; }
        public IFClubBarcelonaContext Context { get; set; }

        public int SaveChanges()
        {
            return this.Context.SaveChanges();
        }
    }
}
