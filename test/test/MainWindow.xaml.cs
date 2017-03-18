using System.Windows;

namespace test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("holaa");
        }
    }
}
