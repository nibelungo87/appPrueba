using System.Windows;

namespace test
{
    public partial class MainWindow : Window
    {
        int r;
        public MainWindow()
        {
            InitializeComponent();
            btnClick.Click += (se, ev) =>
            { r++; btnClick.Content= r.ToString(); };

            btnClick.MouseRightButtonUp += (se, ev) => { r--; btnClick.Content=r.ToString(); };

            
        }
    }
}
