namespace WindowForms_proycto_del_video
{
    public partial class Form1 : Form
    {
        Empleado myEmpleado = new Empleado();
        Nomina myNomina = new Nomina();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlmacenar_Click(object sender, EventArgs e)
        {
            if(txtnombre.Text == "")
            {
                error1.SetError(txtnombre, "Debe ingresar un nombre");
                txtnombre.Focus();
                return;
            }
            error1.SetError(txtnombre, "");

            decimal AsignacionDia;
            if(!Decimal.TryParse(txtasignaciondia.Text, out AsignacionDia))
            {
                error1.SetError(txtasignaciondia, "Debe ingresar un numero");
                txtnombre.Focus();
                return;
            }
            error1.SetError(txtasignaciondia, "");

            myEmpleado.Nombre = txtnombre.Text;
            myEmpleado.Identificacion = txtidentificacion.Text;
            myEmpleado.AsignacionDia = Convert.ToDecimal(txtasignaciondia.Text);
            myNomina.Diaslaborados = Convert.ToInt32(txtdiaslaborados.Text);
            MessageBox.Show("Se guardo el registro correctamente");

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtDevengado.Text = myNomina.CalcularNomina(Convert.ToInt32(myNomina.Diaslaborados), Convert.ToDecimal(myEmpleado.AsignacionDia)).ToString();


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtidentificacion.Clear();
            txtasignaciondia.Clear();
            txtdiaslaborados.Clear();
            txtDevengado.Clear();

        }
    }
}