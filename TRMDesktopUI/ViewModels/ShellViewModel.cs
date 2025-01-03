using Caliburn.Micro;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {

        LoginViewModel _loginVM;
        public ShellViewModel(LoginViewModel loginViewModel)
        {
            _loginVM = loginViewModel;
            ActivateItemAsync(_loginVM);
        }
    }
}
