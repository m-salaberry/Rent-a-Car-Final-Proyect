using BLL;
using Entity;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        public void ActualizarUI()
        {

        }
        private void btnCrearAlquiler_Click(object sender, EventArgs e)
        {
            try
            {
                var FoundCar = carBusiness.GetCarByPlate(txtNuevoPatente.Text);
                RentEntity rentEntity = new RentEntity
                {
                    Client = clientBusiness.GetClientByDni(Convert.ToInt32(txtNuevoDNI.Text)),
                    Car = FoundCar,
                    //Insurance = ,
                    RentDate = dtNuevoInicio.Value,
                    ReturnDate = dtCrearFinAlq.Value,
                    FinalPrice = FoundCar.PricePerDay * (dtCrearFinAlq.Value - dtNuevoInicio.Value).Days,
                };
                rentBusiness.VerificationRent(rentEntity);
                rentBusiness.AddRent(rentEntity);
                MessageBox.Show("Alquiler creado con exito");
                ActualizarUI();
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
            }
        }
    }
}
