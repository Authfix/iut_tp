using System;
using System.Windows;
using System.Windows.Controls;

namespace DemoXaml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On user click on edit button
        /// </summary>
        /// <param name="sender">The edit button</param>
        /// <param name="e">Button parameters</param>
        private void OnEditClick(object sender, RoutedEventArgs e)
        {
            NamedProgressBar.Visibility = Visibility.Visible;

            var window = new DragAndDropView("Je suis le message") {Owner = this};
            // subscribe to event
            window.Unloaded += WindowOnUnloaded;
            // Unsubscribe
            // window.Unloaded -= WindowOnUnloaded;

            window.Show();
        }

        private void WindowOnUnloaded(object sender, RoutedEventArgs routedEventArgs)
        {
            var dragAndDropView = new DragAndDropView("Blblblblbl");
            dragAndDropView.ShowDialog();
        }
    }
}
