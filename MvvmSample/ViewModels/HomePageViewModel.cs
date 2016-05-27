using System.Collections.Generic;
using System.Collections.ObjectModel;
using MvvmSample.Models;
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
            }
        }
    }
}
