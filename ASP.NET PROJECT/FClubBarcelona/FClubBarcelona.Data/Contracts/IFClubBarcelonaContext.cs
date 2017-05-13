using System.Data.Entity;
using FClubBarcelona.Models.IdentityModels;

namespace FClubBarcelona.Data.Contracts
{
    public interface IFClubBarcelonaContext
    {    
        IDbSet<Article> Articles { get; }

        IDbSet<Coach> Coaches { get; }

        IDbSet<Galery> Galeries { get; }

        IDbSet<Video> Videos { get; }

        IDbSet<MessageFromUser> MessageFromUsers { get; }

        IDbSet<Player> Players { get; }

        IDbSet<ApplicationUser> Users { get; }

        DbContext DbContext { get; }

        int SaveChanges();

        IDbSet<T> Set<T>()
           where T : class;
    }
}
