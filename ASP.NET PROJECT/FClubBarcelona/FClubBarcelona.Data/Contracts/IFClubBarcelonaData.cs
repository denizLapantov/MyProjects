using FClubBarcelona.Data.Repositories;
using FClubBarcelona.Models.IdentityModels;

namespace FClubBarcelona.Data.Contracts
{
    public interface IFClubBarcelonaData
    {

        Repository<ApplicationUser> Users { get; }

        Repository<Video> VideoRepository { get; }

        Repository<Galery> GaleryRepository { get; }

        Repository<Article> ArticleRepository { get; }

        Repository<MessageFromUser> MessageRepository { get; }

        Repository<Player> PlayerRepository { get; }

        Repository<Coach> CoachRepository { get; }

        IFClubBarcelonaContext Context { get; }

        int SaveChanges();
    }
}
