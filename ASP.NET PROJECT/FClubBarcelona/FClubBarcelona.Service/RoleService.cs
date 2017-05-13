namespace FClubBarcelona.Service
{
    using System.Collections.Generic;
    using Data;
    using Models.IdentityModels;
    using Models.ViewModels.Account;

    public class RoleService
    {
        public RoleService()
        {
            Roles = new List<SelectRoleEditorViewModel>();
        }


        // Enable initialization with an instance of ApplicationUser:
        public RoleService(ApplicationUser user)
            : this()
        {
            UserName = user.UserName;
            FirstName = user.FirstName;
            LastName = user.LastName;

            var Db = new FClubBarcelonaContext();

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