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
    public partial class ABMSeguro : Form
    {
        public ABMSeguro()
        {
            InitializeComponent();
        }

        InsuranceBusiness insuranceBusiness = new InsuranceBusiness();

        private void btnCrearSeguro_Click(object sender, EventArgs e)
        {
            try
            {
                InsuranceEntity insuranceEntity = new InsuranceEntity
                {
                    TypeOfInsurance = txtCSeguroNombre.Text,
                    Price = Convert.ToDouble(txtCSeguroPrecio.Text)
                };

                insuranceBusiness.AddInsurance(insuranceEntity);
                MessageBox.Show("Se creo correctamente el seguro");
                ActualizarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtCSeguroNombre.Text = "";
                txtCSeguroPrecio.Text = "";
                ActualizarDataGrid();
            }
        }

        private void btnModificarSeguro_Click(object sender, EventArgs e)
        {
            try
            {
                InsuranceEntity insuranceEntity = new InsuranceEntity
                {
                    Id = Convert.ToInt32(txtModID.Text),
                    Price = Convert.ToDouble(txtModSeguroPrecio.Text)
                };

                insuranceBusiness.ModInsurance(insuranceEntity);
                MessageBox.Show("Se modifico correctamente el seguro");
                ActualizarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtModID.Text = "";
                txtModSeguroPrecio.Text = "";
                ActualizarDataGrid();
            }
        }

        private void btnEliminarSeguro_Click(object sender, EventArgs e)
        {
            try
            {
                insuranceBusiness.DeleteInsurance(Convert.ToInt32(txtElimSeguro.Text));
                MessageBox.Show("Se elimino correctamente el seguro");
                ActualizarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtElimSeguro.Text = "";
                ActualizarDataGrid();
            }
        }

        private void ABMSeguro_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            try
            {
                dgvSeguros.DataSource = null;
                if (insuranceBusiness.ListAllInsurances().Count() > 0)
                {
                    dgvSeguros.DataSource = insuranceBusiness.MostrarGrillaDB(insuranceBusiness.ListAllInsurances()).ToList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}