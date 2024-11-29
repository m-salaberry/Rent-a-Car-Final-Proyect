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
            loadDgv();
        }
        ClientBusiness clientBusiness = new ClientBusiness();
        ClientEntity clientMod = null;

        private void btnCrearAlquiler_Click(object sender, EventArgs e)
        {
            try
            {
                ClientEntity client = new ClientEntity()
                {
                    Dni = Convert.ToInt64(txtNClienteDNI.Text),
                    Name = txtNClienteNombre.Text,
                    Surname = txtNClienteApellido.Text,
                    LicenseValidDate = Convert.ToDateTime(dtNClienteVto.Text)
                };

                clientBusiness.AddCliente(client);
                MessageBox.Show("Creacion de cliente exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtNClienteDNI.Text = "";
                txtNClienteNombre.Text = "";
                txtNClienteApellido.Text = "";
                dtNClienteVto.Value = DateTime.Now;
                loadDgv();
            }
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            try
            {
                ClientEntity cliente = clientBusiness.GetClientByDni(Convert.ToInt64(txtModClienteDNI.Text));
                dtModificarVto.Value = cliente.LicenseValidDate;
                cmbModCliente.ValueMember = cliente.BlackList.ToString();
                MessageBox.Show("Cliente encontrado");
                dtModificarVto.Enabled = true;
                cmbModCliente.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                clientMod.LicenseValidDate = dtModificarVto.Value;
                clientMod.BlackList = Convert.ToBoolean(cmbModCliente.Text);
                clientBusiness.ModClient(clientMod);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                clientMod = null;
                dtModificarVto.Value = DateTime.Now;
                dtModificarVto.Enabled = false;
                cmbModCliente.Text = "";
                cmbModCliente.Enabled = false;
                loadDgv();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void loadDgv()
        {
            dgvClients.DataSource = null;
            List<ClientEntity> clientes = clientBusiness.GetAll();
            clientes.OrderBy(x => x.Dni).ToList();
            dgvClients.DataSource = clientes;
        }
        private void ABMClientes_Load(object sender, EventArgs e)
        {
            loadDgv();

        }

        private void btnEliminarCliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                clientBusiness.DeleteClient(Convert.ToInt64(txtElimClienteDNI.Text));
                MessageBox.Show("El cliente fue borrado de la base de datos");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtElimClienteDNI.Text = "";
                loadDgv();
            }
        }
    }
}
