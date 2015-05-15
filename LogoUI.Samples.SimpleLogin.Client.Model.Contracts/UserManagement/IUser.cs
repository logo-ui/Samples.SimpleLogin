using LogoFX.UI.Model.Contracts;

namespace LogoUI.Samples.SimpleLogin.Client.Model.Contracts.UserManagement
{
    public interface IUser : IModel<int>
    {
        string LoginName { get; }
    }
}
