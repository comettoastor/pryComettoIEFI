using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryComettoIEFI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void LimpiarControles()
        {
            txtNombreSocio.Text = "";
            txtApellido.Text = "";
            cmbPais.SelectedIndex = -1;
            numEdad.Value = 50;
            optMasculino.Checked = true;
            numIngreso.Value = 1000;
            numPuntaje.Value = 129.5m;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsPrincipal clsPrincipal = new clsPrincipal();
            clsPrincipal.CargarPaises(cmbPais);
        }

        private void btnRegistrarPais_Click(object sender, EventArgs e)
        {
            if (txtNombrePais.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del país!", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsPrincipal clsPrincipal = new clsPrincipal();
            clsPrincipal.RegistrarPais(txtNombrePais);
            clsPrincipal.CargarPaises(cmbPais);
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            if (txtNombreSocio.Text == "" || txtApellido.Text == "" || cmbPais.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan datos por ingresar!","Faltan datos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            clsPrincipal clsPrincipal = new clsPrincipal();
            clsPrincipal.Nombre = txtNombreSocio.Text;
            clsPrincipal.Apellido = txtApellido.Text;
            clsPrincipal.Pais = cmbPais.Text;
            clsPrincipal.Edad = Convert.ToInt32(numEdad.Value);
            if (optMasculino.Checked)
            {
                clsPrincipal.Sexo = true;
            }
            else
            {
                clsPrincipal.Sexo = false;
            }
            clsPrincipal.Ingreso = numIngreso.Value;
            clsPrincipal.Puntaje = Convert.ToInt32(numPuntaje.Value);

            clsPrincipal.RegistrarSocio();

            LimpiarControles();
        }
    }
}
