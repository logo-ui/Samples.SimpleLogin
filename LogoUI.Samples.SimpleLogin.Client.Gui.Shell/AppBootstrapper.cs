using Caliburn.Micro;
using LogoFX.UI.Bootstrapping.SimpleContainer;
using LogoFX.UI.Navigation;
using LogoUI.Samples.SimpleLogin.Client.Gui.Shell.UiServices;
using LogoUI.Samples.SimpleLogin.Client.Gui.Shell.ViewModels;
using LogoUI.Samples.SimpleLogin.Client.Model.Contracts;
using LogoUI.Samples.SimpleLogin.Client.Model.Fake;

namespace LogoUI.Samples.SimpleLogin.Client.Gui.Shell
{
	public sealed class AppBootstrapper : NavigationBootstrapper<ShellViewModel,ExtendedSimpleIocContainer>
	{
	    protected override void OnConfigure(ExtendedSimpleIocContainer container)
		{
            base.OnConfigure(container);            
            
            container.RegisterSingleton<IShellCloseService, ShellViewModel>();
            container.RegisterSingleton<IWindowManager, ShellViewModel>("LikeRT"); 
            container.RegisterSingleton<ILoginService, FakeLoginService>();
        }	    
	}
}