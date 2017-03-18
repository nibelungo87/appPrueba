using System.Collections.Generic;
using System.Windows.Controls;
using static test.Pages.PageInicio;

namespace test.Pages
{
    public partial class PageMujeres : Page
    {
        private List<Persona> listaClientes = new List<Persona>();

        public PageMujeres(List<Persona> listaClientes)
        {
            InitializeComponent();
            this.listaClientes = listaClientes;

            Llenado();
        }

        private void Llenado()
        {
            foreach (var item in listaClientes)
            {
                if (item.sexo == "femenino")
                {
                    lblItems.Content += $"{item.name} {item.apellido} ({item.sexo}) \n";

                }
            }
        }
    }
}
