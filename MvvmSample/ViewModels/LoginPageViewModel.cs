using System.Windows.Input;
using MvvmSample.Views;
using Prism.Commands;
using Prism.Mvvm;

namespace MvvmSample.ViewModels
{
    public class LoginPageViewModel : BindableBase
    {
        private readonly IView _currentView;
        private readonly IView _viewToOpen;

        /// <summary>
        /// Initialize a default <see cref="LoginPageViewModel"/>
        /// </summary>
        /// <param name="currentView"></param>
        /// <param name="viewToOpen"></param>
        public LoginPageViewModel(IView currentView, IView viewToOpen)
        {
            _logUserInCommand = new DelegateCommand(LogUserIn, CanLogUserIn);

            _currentView = currentView;
            _viewToOpen = viewToOpen;
        }

        private string _login;

        /// <summary>
        /// Gets or sets the user login
        /// Update the <see cref="LogUserInCommand"/>
        /// </summary>
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                _logUserInCommand.RaiseCanExecuteChanged();
            }
        }

        private readonly DelegateCommand _logUserInCommand;
        /// <summary>
        /// Gets the log user in command
        /// </summary>
        public ICommand LogUserInCommand
        {
            get { return _logUserInCommand; }
        }

        /// <summary>
        /// Check if a user can log into the application
        /// </summary>
        /// <returns>Return true if the user can, else false</returns>
        private bool CanLogUserIn()
        {
            return !string.IsNullOrEmpty(Login);
        }

        /// <summary>
        /// Log a user into the application
        /// </summary>
        private void LogUserIn()
        {
            _viewToOpen.Show();

            _currentView.Close();
        }
    }
}
