namespace FClubBarcelona.Models.ViewModels.Account
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.Build.Framework;

    public class SelectRoleEditorViewModel
    {
        public SelectRoleEditorViewModel() { }
        public SelectRoleEditorViewModel(IdentityRole role)
        {
            this.RoleName = role.Name;
            this.Id = role.Id;
        }

        public bool Selected { get; set; }

        [Required]
        public string RoleName { get; set; }

        public string Id { get; set; }
    }
}