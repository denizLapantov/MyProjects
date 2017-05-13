namespace FClubBarcelona.Service.Interfaces
{
    using System.Collections.Generic;
    using Models.BindingModels.Players;
    using Models.ViewModels.Players;

    public interface IPlayersService
    {
        void AddPlayer(PlayersBm model, string user);
        void Delete(int? id);
        PlayersBm DeletePlayer(int? id);
        void Edit(PlayersBm playersBm);
        PlaayersVm EditPlayer(int? id);
        IEnumerable<PlaayersVm> GetAllPlayers();
    }
}