using System.Windows.Input;
using MvvmSample.Models;
using MvvmSample.Views;
using Prism.Commands;

namespace MvvmSample.ViewModels
{
    public class ModificationPageViewModel
    {
        /// <summary>
        /// The view link to this view model
        /// </summary>
        private readonly IView _currentView;

        public ModificationPageViewModel(Character character, IView currentView)
        {
            _currentView = currentView;
            ModificationCharacter = character;

            _validateCommand = new DelegateCommand(ExecuteModificationValidation);
        }

        /// <summary>
        /// Gets the character to update
        /// </summary>
        public Character ModificationCharacter { get; private set; }

        private readonly DelegateCommand _validateCommand;
        /// <summary>
        /// Gets the validate command
        /// </summary>
        public ICommand ValidateCommand
        {
            get { return _validateCommand;}
        }

        /// <summary>
        /// Validate the modification
        /// </summary>
        private void ExecuteModificationValidation()
        {
            _currentView.Close();
        }
    }
}
