using FClubBarcelona.Data.Migrations;

namespace FClubBarcelona.Data
{
    using System.Data.Entity;
    using Models.IdentityModels;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class FClubBarcelonaContext : IdentityDbContext<ApplicationUser>

    {

        public FClubBarcelonaContext()
            : base("name=FClubBarcelonaContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FClubBarcelonaContext,Configuration>());
        }

        public virtual IDbSet<Player> Players { get; set; }

        public virtual IDbSet<Article> Articles { get; set; }

        public virtual IDbSet<MessageFromUser> MessagesFromUsers { get; set; }

        public virtual IDbSet<Galery> Galeries { get; set; }

        public virtual IDbSet<Coach> Coaches { get; set; }

        public virtual IDbSet<Video> Videos { get; set; }
    }

 
}