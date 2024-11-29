namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
    }
}
