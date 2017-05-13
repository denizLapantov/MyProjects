namespace FClubBarcelona.Service.Interfaces
{
    using System.Collections.Generic;
    using Models.ViewModels.Coaches;

    public interface ICoachService
    {
        IEnumerable<CoachVm> GetAllCoaches();
        void AddCoach(CoachVm model);
        CoachVm EditCoach(int? id);
        void Edit(CoachVm coachVm);
        CoachVm DeleteCoach(int? id);
        void Delete(int? id);
    }
}