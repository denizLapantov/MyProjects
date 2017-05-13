namespace FClubBarcelona.Service.Interfaces
{
    using System.Collections.Generic;
    using Models.IdentityModels;
    using Models.ViewModels.MessagesFromUsers;

    public interface IAccountService
    {
        bool AddUserToRole(string userId, string roleName);
        void ClearUserRoles(string userId);
        bool CreateRole(string name);
        bool CreateUser(ApplicationUser user, string password);
        void Delete(int? id);
        AllMessagesFromUsers DeleteMessage(int? id);
        IEnumerable<AllMessagesFromUsers> GetAllMessages(string user);
        bool RoleExists(string name);
    }
}