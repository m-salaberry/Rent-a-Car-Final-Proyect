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
        CarEntity carMod = new CarEntity();

        private void btnCrearAuto_Click(object sender, EventArgs e)
        {
            try
            {
                CarEntity carEntity = new CarEntity
                {
                    Plate = txtCAutoPatente.Text.ToUpper(),
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
            finally
            {
                txtCAutoPatente.Text = "";
                txtCAutoMarca.Text = "";
                txtCAutoModelo.Text = "";
                txtCAutoAno.Text = "";
                txtCAutoPrecio.Text = "";
                txtCAutoKilometraje.Text = "";
                txtCAutoColor.Text = "";
                txtCAutoDetalles.Text = "";
                loadCars();
            }
        }

        private void btnModificarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                carMod.PricePerDay = Convert.ToDouble(txtModAutoPrecio.Text);
                carMod.Kilometers = Convert.ToInt32(txtModAutoKilometraje.Text);
                carMod.Details = txtModAutoDetalles.Text;

                carBusiness.ModCar(carMod);
                MessageBox.Show("La modificación del auto fue exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                carMod = null;
                txtModAutoPatente.Text = "";
                txtModAutoPrecio.Text = "";
                txtModAutoPrecio.Enabled = false;
                txtModAutoKilometraje.Text = "";
                txtModAutoKilometraje.Enabled = false;
                txtModAutoDetalles.Text = "";
                txtModAutoDetalles.Enabled = false;
                loadCars();
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
            finally
            {
                txtElimPatente.Text = "";
                loadCars();
            }
        }

        private void ABMAutos_Load(object sender, EventArgs e)
        {
            loadCars();
        }

        private void btnBuscarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                carMod = carBusiness.GetCarByPlate(txtModAutoPatente.Text.ToUpper());
                txtModAutoPrecio.Text = carMod.PricePerDay.ToString();
                txtModAutoKilometraje.Text = carMod.Kilometers.ToString();
                txtModAutoDetalles.Text = carMod.Details;
                MessageBox.Show("Auto encontrado");
                txtModAutoDetalles.Enabled = true;
                txtModAutoKilometraje.Enabled = true;
                txtModAutoPrecio.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtModAutoPatente.Text = "";
            }
        }

        private void loadCars()
        {
            dgvAllCars.DataSource = null;
            List<CarEntity> cars = carBusiness.GetAllCars();
            cars = cars.OrderBy(c => c.Plate).ToList();
            dgvAllCars.DataSource = cars;
        }
    }
}
