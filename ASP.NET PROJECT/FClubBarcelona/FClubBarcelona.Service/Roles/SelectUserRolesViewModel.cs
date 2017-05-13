using System.Collections.Generic;
using FClubBarcelona.Data;
using FClubBarcelona.Models.IdentityModels;
using FClubBarcelona.Models.ViewModels.Account;

namespace FClubBarcelona.Service.Roles
{
    public class SelectUserRolesViewModel
    {
        public SelectUserRolesViewModel()
        {
            Roles = new List<SelectRoleEditorViewModel>();
        }


        // Enable initialization with an instance of ApplicationUser:
        public SelectUserRolesViewModel(ApplicationUser user)
            : this()
        {
            UserName = user.UserName;
            FirstName = user.FirstName;
            LastName = user.LastName;

            var Db = new FClubBarcelonaContext();

            // Add all available roles to the list of EditorViewModels:
            var allRoles = Db.Roles;
            foreach (var role in allRoles)
            {
                // An EditorViewModel will be used by Editor Template:
                var rvm = new SelectRoleEditorViewModel(role);
                Roles.Add(rvm);
            }

            // Set the Selected property to true for those roles for 
            // which the current user is a member:
            foreach (var userRole in user.Roles)
            {
                var checkUserRole =
                    Roles.Find(r => r.Id == userRole.RoleId);
                checkUserRole.Selected = true;
            }
        }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<SelectRoleEditorViewModel> Roles { get; set; }
    }
}