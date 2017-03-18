using System.Collections.Generic;
using System.Windows;
using test.Pages;
using static test.Pages.PageInicio;

namespace test
{
    public partial class MainWindow : Window
    {
        private List<Persona> listaClientes = new List<Persona>();
        private PageInicio pi;

        public MainWindow()
        {
            InitializeComponent();
            pi = new PageInicio(listaClientes);
            ChrisEvents();
        }

        private void ChrisEvents()
        {
            btnPage1.Click += (se, ev) => { frameMenu.Content = pi; };
            btnPage2.Click += (se, ev) => { frameMenu.Content = new PageMujeres(listaClientes); };
            btnPage3.Click += (se, ev) => { frameMenu.Content = new PageHombres(listaClientes); };
        }
    }
}
