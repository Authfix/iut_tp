using System;
using MvvmSample.ViewModels;

namespace MvvmSample.Views
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : IView
    {
        public LoginPage()
        {
            InitializeComponent();

            DataContext = new LoginPageViewModel(this, new HomePage());

        }
    }
}
