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
    public partial class ABMAutos : Form
    {
        public ABMAutos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        CarBusiness carBusiness = new CarBusiness();

        private void btnCrearAuto_Click(object sender, EventArgs e)
        {
            try
            {
                CarEntity carEntity = new CarEntity
                {
                    Plate = txtCAutoPatente.Text,
                    Brand = txtCAutoMarca.Text,
                    Model = txtCAutoModelo.Text,
                    Year = Convert.ToInt32(txtCAutoAno.Text),
                    PricePerDay = Convert.ToDouble(txtCAutoPrecio.Text),
                    Kilometers = Convert.ToInt32(txtCAutoKilometraje.Text),
                    Color = txtCAutoColor.Text,
                    Details = txtCAutoDetalles.Text
                };

                carBusiness.AddCar(carEntity);
                MessageBox.Show("La creación del auto fue exitosa");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                CarEntity carEntity = new CarEntity
                {
                    Plate = txtModAutoPatente.Text,
                    PricePerDay = Convert.ToDouble(txtModAutoPrecio.Text),
                    Kilometers = Convert.ToInt32(txtModAutoKilometraje.Text),
                    Details = txtModAutoDetalles.Text
                };

                carBusiness.ModCar(carEntity);
                MessageBox.Show("La modificación del auto fue exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                carBusiness.DeleteCar(txtElimPatente.Text);
                MessageBox.Show("La eliminación del auto fue exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ABMAutos_Load(object sender, EventArgs e)
        {

        }
    }
}
