namespace FClubBarcelona.Service
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using AutoMapper;
    using Models.IdentityModels;
    using Models.ViewModels.Coaches;
    using Interfaces;

    public class CoachService :Service, ICoachService
    {
        public IEnumerable<CoachVm> GetAllCoaches()
        {
            IEnumerable<Coach> coaches = Context.Coaches;
            IEnumerable<CoachVm> model = Mapper.Map<IEnumerable<Coach>, IEnumerable<CoachVm>>(coaches);
            return model;
        }

        public void AddCoach(CoachVm model)
        {
            Coach coach = Mapper.Map<CoachVm, Coach>(model);
            Context.Coaches.Add(coach);
            Context.SaveChanges();
        }

        public CoachVm EditCoach(int? id)
        {
            Coach coach = Context.Coaches.Find(id);
            CoachVm model = Mapper.Map<Coach, CoachVm>(coach);
            return model;
        }

        public void Edit(CoachVm coachVm)
        {
            Coach coach = Mapper.Map<CoachVm, Coach>(coachVm);
            Context.Entry(coach).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public CoachVm DeleteCoach(int? id)
        {
            Coach coach = Context.Coaches.Find(id);
            CoachVm model = Mapper.Map<Coach, CoachVm>(coach);
            return model;
        }

        public void Delete(int? id)
        {
            Coach entityToDelete = Context.Coaches.Find(id);
            Context.Coaches.Remove(entityToDelete);
            Context.SaveChanges();
        }
    }
}
