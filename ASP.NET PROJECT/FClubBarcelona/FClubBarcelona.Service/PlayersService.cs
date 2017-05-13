namespace FClubBarcelona.Service
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using AutoMapper;
    using Models.BindingModels.Players;
    using Models.IdentityModels;
    using Models.ViewModels.Players;
    using Interfaces;

    public class PlayersService : Service, IPlayersService
    {
        public IEnumerable<PlaayersVm> GetAllPlayers()
        {
            IEnumerable<Player> players = Context.Players;
            IEnumerable<PlaayersVm> model = Mapper.Map<IEnumerable<Player>, IEnumerable<PlaayersVm>>(players);
            return model;
        }

        public void AddPlayer(PlayersBm model, string user)
        {
            var userName = Context.Users.FirstOrDefault(x => x.UserName == user);
            Player player = Mapper.Map < PlayersBm, Player>(model);
            player.AdminAuthor = userName;
            Context.Players.Add(player);
            Context.SaveChanges();
        }

        public PlaayersVm EditPlayer(int? id)
        {
            Player player = Context.Players.Find(id);
            PlaayersVm model = Mapper.Map<Player, PlaayersVm>(player);
            return model;
        }

        public void Edit(PlayersBm playersBm)
        {
            Player player = Mapper.Map<PlayersBm, Player>(playersBm);
            Context.Entry(player).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public PlayersBm DeletePlayer(int? id)
        {
            Player player = Context.Players.Find(id);
            PlayersBm model = Mapper.Map<Player, PlayersBm>(player);
            return model;
        }

        public void Delete(int? id)
        {
            Player entityToDelete = Context.Players.Find(id);
            Context.Players.Remove(entityToDelete);
            Context.SaveChanges();
        }
    }
}
