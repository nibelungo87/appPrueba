﻿using System.Windows;

namespace test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnClick.Click += (se, ev) => { MessageBox.Show("Click"); };
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("holaa");
        }
    }
}
