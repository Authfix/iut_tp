using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MvvmSample.Models;
using Prism.Commands;
using Prism.Mvvm;

namespace MvvmSample.ViewModels
{
    public class HomePageViewModel : BindableBase
    {
        public HomePageViewModel()
        {
            _items = new ObservableCollection<Character>();
            _items.Add(new Character("C3PO", "Boite de conserve"));
            _items.Add(new Character("Z6PO", "Boite de conserve francaise"));
            _items.Add(new Character("Chewbacca", "Chewy"));

            _deleteCharacterCommand = new DelegateCommand(ExecuteDeleteCharacter, CanDeleteCharacter);
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
    }
}
