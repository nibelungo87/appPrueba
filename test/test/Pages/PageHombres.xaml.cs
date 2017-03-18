using System.Collections.Generic;
using System.Windows.Controls;
using static test.Pages.PageInicio;

namespace test.Pages
{
    public partial class PageHombres : Page
    {
        public List<Persona> listaClientes = new List<Persona>();

        public PageHombres(List<Persona> listaClientes)
        {
            InitializeComponent();
            this.listaClientes = listaClientes;

        }
    }
}
