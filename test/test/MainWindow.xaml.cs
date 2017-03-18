using System.Windows;

namespace test
{
    public partial class MainWindow : Window
    {
        // Variables globales
        int myInt;

        public MainWindow()
        {
            InitializeComponent();
            ChrisEvents();
        }

        private void ChrisEvents()
        {
            btnClick.Click += (se, ev) => { myInt++; btnClick.Content = $"{myInt}"; };
            btnClick.MouseRightButtonUp += (se, ev) => { myInt--; btnClick.Content = $"{myInt}"; };
        }
    }
}
