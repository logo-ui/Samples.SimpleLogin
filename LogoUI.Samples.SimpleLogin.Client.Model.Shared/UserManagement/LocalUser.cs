using LogoUI.Samples.SimpleLogin.Client.Model.Contracts.UserManagement;

namespace LogoUI.Samples.SimpleLogin.Client.Model.Shared.UserManagement
{
    public sealed class LocalUser : UserBase, ILocalUser
    {
        public bool IsAdmin { get; set; }
    }
}
