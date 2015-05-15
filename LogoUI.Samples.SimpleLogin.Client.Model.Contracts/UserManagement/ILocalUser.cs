namespace LogoUI.Samples.SimpleLogin.Client.Model.Contracts.UserManagement
{
    public interface ILocalUser : IUser
    {
        bool IsAdmin { get; }
    }
}
