namespace FClubBarcelona.Service
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Data;
    using Models.IdentityModels;
    using Models.ViewModels.MessagesFromUsers;
    using Interfaces;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class AccountService : Service, IAccountService
    {

        public bool RoleExists(string name)
        {
            var rm = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(new FClubBarcelonaContext()));
            return rm.RoleExists(name);
        }


        public bool CreateRole(string name)
        {
            var rm = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(new FClubBarcelonaContext()));
            var idResult = rm.Create(new IdentityRole(name));
            return idResult.Succeeded;
        }


        public bool CreateUser(ApplicationUser user, string password)
        {
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(new FClubBarcelonaContext()));
            var idResult = um.Create(user, password);
            return idResult.Succeeded;
        }


        public bool AddUserToRole(string userId, string roleName)
        {
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(new FClubBarcelonaContext()));
            var idResult = um.AddToRole(userId, roleName);
            return idResult.Succeeded;
        }


        public void ClearUserRoles(string userId)
        {
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(new FClubBarcelonaContext()));
            var user = um.FindById(userId);
            var currentRoles = new List<IdentityUserRole>();
            currentRoles.AddRange(user.Roles);

            foreach (var role in currentRoles)
            {
                um.RemoveFromRole(userId, role.RoleId);

            }
        }

        public IEnumerable<AllMessagesFromUsers> GetAllMessages(string user)
        {
            var currentUseer = Context.Users.FirstOrDefault(x => x.FirstName.ToLower() == user.ToLower());
            IEnumerable<MessageFromUser> messages = Context.MessagesFromUsers;
            IEnumerable<AllMessagesFromUsers> model = Mapper.Map<IEnumerable<MessageFromUser>, IEnumerable<AllMessagesFromUsers>>(messages);
            foreach (var messageFromUser in messages)
            {
                messageFromUser.Sender = currentUseer;
            }
            //foreach (var allMessagesFromUserse in model)
            //{
            //    if (allMessagesFromUserse.Sender.FirstName == currentUseer.FirstName)
            //    {
            //        allMessagesFromUserse.Sender.FirstName = currentUseer.FirstName;
            //    }
              
            //}
            return model;
        }

        public AllMessagesFromUsers DeleteMessage(int? id)
        {
            MessageFromUser messageas = Context.MessagesFromUsers.Find(id);
            AllMessagesFromUsers model = Mapper.Map<MessageFromUser, AllMessagesFromUsers>(messageas);
            return model;
        }

        public void Delete(int? id)
        {
            MessageFromUser entityToDelete = Context.MessagesFromUsers.Find(id);
            Context.MessagesFromUsers.Remove(entityToDelete);
            Context.SaveChanges();
        }
    }
}
