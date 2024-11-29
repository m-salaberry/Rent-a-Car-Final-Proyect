using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ABMClientes : Form
    {
        public ABMClientes()
        {
            InitializeComponent();
        }
        ClientBusiness clientBusiness = new ClientBusiness();

        private void btnCrearAlquiler_Click(object sender, EventArgs e)
        {
            try
            {
                ClientEntity client = new ClientEntity()
                {
                    Dni = Convert.ToInt32(txtNClienteDNI.Text),
                    Name = txtNClienteNombre.Text,
                    Surname = txtNClienteApellido.Text,
                    LicenseValidDate = Convert.ToDateTime(dtNClienteVto.Text),
                    //BlackList = cmbNHabilitado.Text,

                };

                clientBusiness.AddCliente(client);
                MessageBox.Show("Creacion de cliente exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
