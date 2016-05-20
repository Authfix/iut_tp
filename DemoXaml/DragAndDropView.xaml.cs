using System.Windows;

namespace DemoXaml
{
    /// <summary>
    /// Interaction logic for DragAndDropView.xaml
    /// </summary>
    public partial class DragAndDropView : Window
    {
        public DragAndDropView(string message)
        {
            InitializeComponent();

            NamedTextBox.Text = message;
        }
    }
}
