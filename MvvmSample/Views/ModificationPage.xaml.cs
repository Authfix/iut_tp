using MvvmSample.Models;
using MvvmSample.ViewModels;

namespace MvvmSample.Views
{
    /// <summary>
    /// Interaction logic for ModificationPage.xaml
    /// </summary>
    public partial class ModificationPage : IView
    {
        public ModificationPage(Character character)
        {
            InitializeComponent();

            DataContext = new ModificationPageViewModel(character, this);
        }
    }
}
