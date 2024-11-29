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
                CarEntity carEntity = new CarEntity
                {
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
            finally
            {
                txtModAutoPatente.Text = "";
                txtModAutoPrecio.Text = "";
                txtModAutoKilometraje.Text = "";
                txtModAutoDetalles.Text = "";
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
                CarEntity carBase = carBusiness.GetCarByPlate(txtModAutoPatente.Text.ToUpper());
                txtModAutoPrecio.Text = carBase.PricePerDay.ToString();
                txtModAutoKilometraje.Text = carBase.Kilometers.ToString();
                txtModAutoDetalles.Text = carBase.Details;
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
