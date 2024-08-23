using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Nomina
{
    public partial class Permisos : Form
    {
        public Permisos()
        {
            InitializeComponent();
            CargarPermisos();
        }

        MySqlConnection cn = Conexion.getConexion();
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtID.Text) ||
                string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                string.IsNullOrWhiteSpace(TxtDescr.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }

            try
            {
                cn.Open();

                string insertQuery = @"
                INSERT INTO Permisos (ID_usuario, Nom_usuario, Descripcion)
                VALUES (@ID_usuario, @Nombre, @Descrip)";

                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, cn))
                {
                    insertCommand.Parameters.AddWithValue("@ID_usuario", TxtID.Text);
                    insertCommand.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                    insertCommand.Parameters.AddWithValue("@Descrip", TxtDescr.Text);

                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("¡Permiso guardado correctamente!");

                    LimpiarCamposPerm();
                    CargarPermisos(); // Recargar los datos después de guardar
                }

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtID.Text, out int idusuario))
            {
                try
                {
                    using (MySqlConnection cn = Conexion.getConexion())
                    {
                        cn.Open();

                        string query = @"
                        SELECT usuario
                        FROM  usuarios
                        WHERE id = @ID_usuario";

                        using (MySqlCommand comando = new MySqlCommand(query, cn))
                        {
                            comando.Parameters.AddWithValue("@ID_usuario", idusuario);

                            using (MySqlDataReader reader = comando.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    TxtNombre.Text = reader["usuario"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró ningún empleado con el ID proporcionado.");
                                    TxtNombre.Text = "";
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de empleado válido.");
            }
        }

        private void LimpiarCamposPerm()
        {
            TxtID.Text = "";
            TxtNombre.Text = "";
            TxtDescr.Text = "";
        }
        private void CargarPermisos()
        {
            try
            {
                string query = "SELECT ID_Permiso, ID_usuario, Nom_usuario, Descripcion FROM Permisos";

                using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, cn))
                {
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridViewPermisos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar permisos: " + ex.Message);
            }
        }

        private void BtnMENU_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void Permisos_Load(object sender, EventArgs e)
        {

        }
    }
}
//Angel Ajanel
