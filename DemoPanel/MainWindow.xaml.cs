using System.Windows;

namespace DemoPanel
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenCanvas_Click(object sender, RoutedEventArgs e) => new DemoCanvasPanel().Show();
        private void OpenWrap_Click(object sender, RoutedEventArgs e) => new DemoWrapPanel().Show();
        private void OpenStack_Click(object sender, RoutedEventArgs e) => new DemoStackPanel().Show();
        private void OpenGrid_Click(object sender, RoutedEventArgs e) => new DemoGridPanel().Show();
        private void OpenDock_Click(object sender, RoutedEventArgs e) => new DemoDockPanel().Show();
    }
}
