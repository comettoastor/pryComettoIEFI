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
        
        clsPrincipal clsPrincipal = new clsPrincipal();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsPrincipal.CargarPaises(cmbPais);
        }

        private void btnRegistrarPais_Click(object sender, EventArgs e)
        {
            if (txtNombrePais.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del país!", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsPrincipal.RegistrarPais(txtNombrePais.Text);
            clsPrincipal.CargarPaises(cmbPais);
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            if (txtNombreSocio.Text == "" || txtApellido.Text == "" || cmbPais.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan datos por ingresar!","Faltan datos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            clsPrincipal.Nombre = txtNombreSocio.Text;
            clsPrincipal.Apellido = txtApellido.Text;
            clsPrincipal.Pais = cmbPais.Text;
            clsPrincipal.Edad = Convert.ToInt32(numEdad.Value);
            if (optMasculino.Checked)
            {
                clsPrincipal.Sexo = -1;
            }
            else
            {
                clsPrincipal.Sexo = 0;
            }
            clsPrincipal.Ingreso = numIngreso.Value;
            clsPrincipal.Puntaje = Convert.ToInt32(numPuntaje.Value);
        }
    }
}
