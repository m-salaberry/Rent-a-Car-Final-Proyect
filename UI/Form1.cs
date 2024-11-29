using BLL;
using Entity;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadDgv();
        }
        ClientBusiness clientBusiness = new ClientBusiness();
        CarBusiness carBusiness = new CarBusiness();
        InsuranceBusiness insuranceBusiness = new InsuranceBusiness();
        RentBusiness rentBusiness = new RentBusiness();
        private void btnABMClientes_Click(object sender, EventArgs e)
        {
            ABMClientes abmClientesForm = new ABMClientes();
            abmClientesForm.Show();
        }

        private void btnABMAutos_Click(object sender, EventArgs e)
        {
            ABMAutos abmAutosForm = new ABMAutos();
            abmAutosForm.Show();
        }

        private void btnABMSeguros_Click(object sender, EventArgs e)
        {
            ABMSeguro aBMSeguro = new ABMSeguro();
            aBMSeguro.Show();
        }


        private void btnCrearAlquiler_Click(object sender, EventArgs e)
        {
            try
            {
                CarEntity FoundCar = carBusiness.GetCarByPlate(txtNuevoPatente.Text.ToUpper());
                InsuranceEntity InsuranceSelected = insuranceBusiness.GetInsuranceById(Convert.ToInt32(cmbCrearSeguro.SelectedValue));
                ClientEntity clientSelected = clientBusiness.GetClientByDni(Convert.ToInt64(txtNuevoDNI.Text));
                RentEntity rentEntity = new RentEntity
                {
                    Client = clientSelected,
                    Car = FoundCar,
                    Insurance = InsuranceSelected,
                    RentDate = dtNuevoInicio.Value,
                    ReturnDate = dtCrearFinAlq.Value,
                    FinalPrice = FoundCar.PricePerDay * (dtCrearFinAlq.Value - dtNuevoInicio.Value).Days,
                };
                rentBusiness.AddRent(rentEntity);
                MessageBox.Show("Alquiler creado con exito");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtNuevoDNI.Text = "";
                txtNuevoPatente.Text = "";
                dtNuevoInicio.Value = DateTime.Now;
                dtCrearFinAlq.Value = DateTime.Now;
                loadDgv();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDgv();
            loadCmbSeguros();
        }

        private void loadDgv()
        {
            dgvAlquileres.DataSource = null;
            dgvAlquileres.DataSource = rentBusiness.GetAllRents();
            dgvAlquileres.Columns["Client"].Visible = false;
            dgvAlquileres.Columns["Car"].Visible = false;
            dgvAlquileres.Columns["Insurance"].Visible = false;
        }

        private void loadCmbSeguros()
        {
            cmbCrearSeguro.DataSource = null;
            List<InsuranceEntity> insurances = insuranceBusiness.ListAllInsurances();
            insurances.OrderBy(x => x.Id).ToList();
            cmbCrearSeguro.DataSource = insurances;
            cmbCrearSeguro.DisplayMember = "TypeOfInsurance";
            cmbCrearSeguro.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rentBusiness.DeleteRent(textBox1.Text, Convert.ToInt32(txtDniCancelar.Text));
                MessageBox.Show("Alquiler eliminado con exito");
                loadDgv();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
