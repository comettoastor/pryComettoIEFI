using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryComettoIEFI
{
    internal class clsPrincipal
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Pais { get; set; }
        public int Edad { get; set; }
        public bool Sexo { get; set; }
        public decimal Ingreso { get; set; }
        public int Puntaje { get; set; }

        public OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb;Persist Security Info=False;");

        public void RegistrarPais(TextBox NombrePais)
        {
            bool encontrado = false;
            using (OleDbCommand Comando = new OleDbCommand())
            {
                Comando.Connection = Conexion;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "SELECT PAIS FROM PAISES WHERE PAIS = ?";
                Comando.Parameters.AddWithValue("@Nombre", NombrePais.Text);

                Conexion.Open();

                using (OleDbDataReader Lector = Comando.ExecuteReader())
                {
                    if (Lector.HasRows)
                    {
                        MessageBox.Show("El país ingresado ya existe!", "Ya existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        encontrado = true;
                    }
                }

                Conexion.Close();
            }

            if (encontrado == true) 
            {
                NombrePais.Text = "";
                return;
            }

            using (OleDbCommand Comando = new OleDbCommand())
            {
                Comando.Connection = Conexion;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "INSERT INTO PAISES (PAIS) VALUES (?)";
                Comando.Parameters.AddWithValue("@Nombre", NombrePais.Text);

                Conexion.Open();

                Comando.ExecuteNonQuery();

                Conexion.Close();

                NombrePais.Text = "";

                MessageBox.Show("País ingresado con éxito!", "Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void CargarPaises(ComboBox cmbPais)
        {
            using (OleDbCommand Comando = new OleDbCommand())
            {
                Comando.Connection = Conexion;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "SELECT PAIS FROM PAISES";

                Conexion.Open();

                using (OleDbDataReader Lector = Comando.ExecuteReader())
                {
                    if (Lector.HasRows)
                    {
                        cmbPais.Items.Clear();
                        while (Lector.Read())
                        {
                            cmbPais.Items.Add(Lector.GetString(0));
                        }
                    }
                }

                Conexion.Close();
            }
            
        }

        public void RegistrarSocio()
        {
            using (OleDbCommand Comando = new OleDbCommand())
            {
                Comando.Connection = Conexion;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "SELECT NOMBRE,APELLIDO FROM SOCIOS WHERE NOMBRE = ? AND APELLIDO = ?";
                Comando.Parameters.AddWithValue("@Nombre", Nombre);
                Comando.Parameters.AddWithValue("@Apellido", Apellido);

                Conexion.Open();

                using (OleDbDataReader Lector = Comando.ExecuteReader())
                {
                    if (Lector.HasRows)
                    {
                        DialogResult dialogResult = MessageBox.Show("El usuario ingresado ya existe! ¿Desea registrarlo igualmente?", "Ya existe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.No)
                        {
                            return;
                        }
                    }
                }

                Comando.Parameters.Clear();
                Comando.CommandText = "INSERT INTO SOCIOS (NOMBRE,APELLIDO,LUGAR_NACIMIENTO,EDAD,SEXO,INGRESO,PUNTAJE) VALUES (?,?,?,?,?,?,?)";
                Comando.Parameters.AddWithValue("@Nombre", Nombre);
                Comando.Parameters.AddWithValue("@Apellido", Apellido);
                Comando.Parameters.AddWithValue("@Lugar_Nacimiento", Pais);
                Comando.Parameters.AddWithValue("@Edad", Edad);
                Comando.Parameters.AddWithValue("@Sexo", Sexo);
                Comando.Parameters.AddWithValue("@Ingreso", Ingreso);
                Comando.Parameters.AddWithValue("@Puntaje", Puntaje);

                Comando.ExecuteNonQuery();

                Conexion.Close();

                MessageBox.Show("Usuario ingresado con éxito!","Ingresado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
    }
}
