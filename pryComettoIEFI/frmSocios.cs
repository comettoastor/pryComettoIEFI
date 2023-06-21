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
        
        //clsPrincipal clsPrincipal = new clsPrincipal();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsPrincipal clsPrincipal = new clsPrincipal();
            clsPrincipal.CargarPaises(cmbPais);
        }

        private void btnRegistrarPais_Click(object sender, EventArgs e)
        {
            clsPrincipal clsPrincipal = new clsPrincipal();
            clsPrincipal.RegistrarPais(txtNombrePais.Text);
            clsPrincipal.CargarPaises(cmbPais);
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            clsPrincipal clsPrincipal = new clsPrincipal();
            if (optMasculino.Checked)
            {
                clsPrincipal.Sexo = true;
            }
            else
            {
                clsPrincipal.Sexo = false;
            }
        }
    }
}
