using System.Windows;
using test.Pages;

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
            btnPage1.Click += (se, ev) => { frameMenu.Content = new Page1(); };
            btnPage2.Click += (se, ev) => { frameMenu.Content = new Page2(); };
        }
    }
}
