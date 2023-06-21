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
        public OleDbCommand Comando = new OleDbCommand();
        public OleDbDataReader Lector;

        public void RegistrarPais(string NombrePais)
        {
            try
            {
                using (Comando)
                {
                    Conexion.Open();
                    Comando.Connection = Conexion;
                    Comando.CommandType = System.Data.CommandType.Text;
                    Comando.CommandText = "SELECT PAIS FROM PAISES WHERE PAIS = ?";
                    Comando.Parameters.AddWithValue("@Nombre", NombrePais);

                    using (Lector = Comando.ExecuteReader())
                    {
                        if (Lector.HasRows)
                        {
                            MessageBox.Show("El país ingresado ya existe!", "Ya existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Comando.Connection.Close();
                            return;
                        }

                        Comando.CommandText = "INSERT INTO PAISES (PAIS) VALUES (?)";

                        Comando.ExecuteNonQuery();
                    }

                    Conexion.Close();
            }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        public void CargarPaises(ComboBox cmbPais)
        {
            using (Comando)
            {
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "SELECT PAIS FROM PAISES";

                using (Lector = Comando.ExecuteReader())
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
            Comando.Connection = Conexion;
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = "SELECT NOMBRE,APELLIDO FROM SOCIOS WHERE NOMBRE = ? AND APELLIDO = ?";
            Comando.Parameters.AddWithValue("@Nombre", Nombre);
            Comando.Parameters.AddWithValue("@Apellido", Apellido);

            Comando.Connection.Open();
            Lector = Comando.ExecuteReader();

            if (Lector.HasRows)
            {
                MessageBox.Show("El usuario ingresado ya existe! ¿Desea registrarlo igualmente?", "Ya existe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                return;
            }

            Lector.Close();

            Comando.CommandText = "INSERT INTO PAISES (PAIS) VALUES (?)";

            Comando.ExecuteNonQuery();

            Comando.Connection.Close();
        }
    }
}
