using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace test.Pages
{
    public partial class PageInicio : Page
    {
        public class Persona
        {
            public string name { get; set; }
            public string apellido { get; set; }
            public string sexo { get; set; }
        }

        private List<Persona> listaClientes = new List<Persona>();

        public PageInicio(List<Persona> listaClientes)
        {
            InitializeComponent();
            this.listaClientes = listaClientes;
            cbItems.Items.Add("seleccione");
            cbItems.Items.Add("femenino");
            cbItems.Items.Add("masculino");
            cbItems.SelectedIndex = 0;
            btnAccion.Click += (se, ev) => 
            {
                if (cbItems.SelectedValue.Equals("seleccione"))                   
                {
                    MessageBox.Show($"seleccione sexo");
                }
                else
                {
                    Persona p = new Persona()
                    {
                        name = txt1.Text,
                        apellido = txt2.Text,
                        sexo= cbItems.SelectedItem.ToString()
                    };
                    listaClientes.Add(p);
                    MessageBox.Show($"cliente {p.name} agregado");
                    LimpiarCampos();
                    Llenado();
                }
            };
        }

        private void LimpiarCampos()
        {
            txt1.Clear();
            txt2.Clear();
            cbItems.SelectedIndex = 0;
            lblItems.Content = "";
        }
        private void Llenado()
        {
            foreach (var item in listaClientes)
            {
                lblItems.Content += $"{item.name} {item.apellido} ({item.sexo}) \n";
            }
        }
    }
}
