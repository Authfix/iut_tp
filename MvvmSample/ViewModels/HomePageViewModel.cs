using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MvvmSample.Models;
using MvvmSample.Views;
using Prism.Commands;
using Prism.Mvvm;

namespace MvvmSample.ViewModels
{
    public class HomePageViewModel : BindableBase
    {
        public HomePageViewModel()
        {
            _items = new ObservableCollection<Character>
            {
                new Character("C3PO", "Boite de conserve"),
                new Character("Z6PO", "Boite de conserve francaise"),
                new Character("Chewbacca", "Chewy")
            };

            _deleteCharacterCommand = new DelegateCommand(ExecuteDeleteCharacter, CanDeleteCharacter);
            _createCharacterCommand = new DelegateCommand(ExecuteCreateCharacter);
        }

        private readonly ObservableCollection<Character> _items;
        /// <summary>
        /// Gets the items for this view model
        /// </summary>
        public IEnumerable<Character> Items
        {
            get { return _items;}
        }

        private Character _selectedCharacter;
        /// <summary>
        /// Gets or sets the selected character
        /// </summary>
        public Character SelectedCharacter
        {
            get { return _selectedCharacter;}
            set
            {
                _selectedCharacter = value;
                OnPropertyChanged(() => SelectedCharacter);
                _deleteCharacterCommand.RaiseCanExecuteChanged();
            }
        }

        private readonly DelegateCommand _deleteCharacterCommand;
        /// <summary>
        /// Gets the delete character command
        /// </summary>
        public ICommand DeleteCharacterCommand
        {
            get { return _deleteCharacterCommand;}
        }

        private readonly DelegateCommand _createCharacterCommand;
        /// <summary>
        /// Gets the modification character command
        /// </summary>
        public ICommand CreateCharacterCommand
        {
            get { return _createCharacterCommand; }
        }

        /// <summary>
        /// Delete the character
        /// </summary>
        private void ExecuteDeleteCharacter()
        {
            _items.Remove(SelectedCharacter);
        }

        /// <summary>
        /// Check if we can delete a character
        /// </summary>
        /// <returns>True if we can, else false</returns>
        private bool CanDeleteCharacter()
        {
            return _selectedCharacter != null;
        }

        /// <summary>
        /// Create a character
        /// </summary>
        private void ExecuteCreateCharacter()
        {
            var character = new Character(string.Empty, string.Empty);
            var createPage = new ModificationPage(character);

            createPage.ShowDialog();

            if (!string.IsNullOrEmpty(character.Name) && !string.IsNullOrEmpty(character.Surname))
            {
                _items.Add(character);
            }
        }
    }
}
