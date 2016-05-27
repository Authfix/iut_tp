using MvvmSample.Views;

namespace MvvmSample.Tests.Views
{
    internal class MockView : IView
    {
        public void Close()
        {
            
        }

        public bool? ShowDialog()
        {
            return true;
        }

        public void Show()
        {
        }
    }
}
