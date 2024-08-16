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
                INSERT INTO Permisos (Nombre, Descrip, ID_Empl, FechaPerm)
                VALUES (@Nombre, @Descrip, @ID_Empl, @FechaPerm)";

                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, cn))
                {
                    insertCommand.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                    insertCommand.Parameters.AddWithValue("@Descrip", TxtDescr.Text);
                    insertCommand.Parameters.AddWithValue("@ID_Empl", TxtID.Text);
                    insertCommand.Parameters.AddWithValue("@FechaPerm", DTPFechaPerm.Value.ToString("yyyy-MM-dd"));

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

        private void LimpiarCampos()
        {
            // Limpiar los campos del formulario
            TxtID.Clear();
            TxtDescr.Clear();
            DTPFechaPerm.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtID.Text, out int idEmpleado))
            {
                try
                {
                    using (MySqlConnection cn = Conexion.getConexion())
                    {
                        cn.Open();

                        string query = @"
                        SELECT Nombre
                        FROM empleados 
                        WHERE ID_empleado = @IDEmpls";

                        using (MySqlCommand comando = new MySqlCommand(query, cn))
                        {
                            comando.Parameters.AddWithValue("@IDEmpls", idEmpleado);

                            using (MySqlDataReader reader = comando.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    TxtNombre.Text = reader["Nombre"].ToString();
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
                string query = "SELECT ID_Permiso, Nombre, FechaPerm, Descrip, ID_Empl FROM Permisos";

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
    }
}
