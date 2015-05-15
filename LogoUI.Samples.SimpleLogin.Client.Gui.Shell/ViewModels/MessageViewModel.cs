using System.Threading.Tasks;
using System.Windows.Input;
using Caliburn.Micro;
using LogoFX.UI.Commanding;

namespace LogoUI.Samples.SimpleLogin.Client.Gui.Shell.ViewModels
{
    public sealed class MessageViewModel : Screen
    {
        private readonly TaskCompletionSource<MessageResult> _messageCompletionSource;

        public MessageViewModel(
            TaskCompletionSource<MessageResult> messageCompletionSource, 
            string message, 
            string caption = "", 
            MessageButton button = MessageButton.OK, 
            MessageImage icon = MessageImage.None)
        {
            _messageCompletionSource = messageCompletionSource;
            Message = message;
            Caption = caption;
            Button = button;
            Icon = icon;
        }
        
        private ICommand _clickCommand;
        public ICommand ClickCommand
        {
            get
            {
                return _clickCommand ??
                       (_clickCommand = ActionCommand<MessageResult>
                           .Do(result => _messageCompletionSource.SetResult(result)));
            }
        }

        public string Message { get; private set; }

        public string Caption { get; private set; }

        public MessageButton Button { get; private set; }

        public MessageImage Icon { get; private set; }

        public bool ButtonOkVisible
        {
            get { return Button == MessageButton.OK || Button == MessageButton.OKCancel; }
        }

        public bool ButtonCancelVisible
        {
            get { return Button == MessageButton.OKCancel || Button == MessageButton.YesNoCancel; }
        }

        public bool ButtonYesVisible
        {
            get { return Button == MessageButton.YesNo || Button == MessageButton.YesNoCancel; }
        }

        public bool ButtonNoVisible
        {
            get { return Button == MessageButton.YesNo || Button == MessageButton.YesNoCancel; }
        }
    }
}