using System.Threading.Tasks;

namespace LogoUI.Samples.SimpleLogin.Client.Model.Contracts
{
    public interface ILoginService
    {
        Task<bool> Login(string loginName, string password, bool persist = false);
        Task<bool> LogOut();
    }
}
