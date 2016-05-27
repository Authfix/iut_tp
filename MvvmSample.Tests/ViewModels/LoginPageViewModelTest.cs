using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvvmSample.Tests.Views;
using MvvmSample.ViewModels;

namespace MvvmSample.Tests.ViewModels
{
    [TestClass]
    public class LoginPageViewModelTest
    {
        [TestMethod]
        public void CheckLoginCommandKoWhenLoginEmpty()
        {
            var loginPageViewModel = new LoginPageViewModel(new MockView(), new MockView());

            Assert.IsTrue(string.IsNullOrEmpty(loginPageViewModel.Login));
            Assert.IsFalse(loginPageViewModel.LogUserInCommand.CanExecute(null));
        }

        [TestMethod]
        public void CheckLoginCommandOkWhenLoginNotEmpty()
        {
            var loginPageViewModel = new LoginPageViewModel(new MockView(), new MockView()) {Login = "test"};

            Assert.IsTrue(loginPageViewModel.LogUserInCommand.CanExecute(null));
        }
    }
}
