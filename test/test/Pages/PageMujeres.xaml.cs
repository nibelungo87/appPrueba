using System.Collections.Generic;
using System.Windows;
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
            btnAccion.Click += (se, ev) =>
            {
                btnAccion.IsEnabled = false;
            };
        }

        private void Llenado()
        {
            btnAccion.IsEnabled = false;
            foreach (var item in listaClientes)
            {
                if (item.sexo == "femenino")
                {
                    Label lbItem = new Label()
                    {
                        Content = $"{item.name} {item.apellido} ({item.sexo})"
                    };
                    lbItem.MouseUp += (se, ev) => { SeleccionarItem(item); };
                    spItems.Children.Add(lbItem);
                }
            }
        }

        private void SeleccionarItem(Persona p)
        {
            txt1.Text = p.name;
            txt2.Text = p.apellido;
            cbItems.SelectedValue = p.sexo;
            btnAccion.IsEnabled = true;
        }
    }
}
