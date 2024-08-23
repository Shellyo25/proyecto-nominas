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
    public partial class Rol : Form
    {
        public Rol()
        {
            InitializeComponent();
        }
        MySqlConnection cn = Conexion.getConexion();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            {
                try
                {
                    cn.Open();
                    string query = "INSERT INTO Roles (Id_permiso, ID_usuario, nombre, Descripcion) " +
                        "VALUES (@IdPermiso, @IdUsr,@Nombre, @Descripcion)";

                    using (MySqlCommand command = new MySqlCommand(query, cn))
                    {
                        command.Parameters.AddWithValue("@IdPermiso", txtIdPerm.Text);
                        command.Parameters.AddWithValue("@IdUsr", txtIdUsr.Text);
                        command.Parameters.AddWithValue("@Nombre", txtNomUsuario.Text);
                        command.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se guardaron los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdPerm.Text, out int idpermiso))
            {
                try
                {
                    using (MySqlConnection cn = Conexion.getConexion())
                    {
                        cn.Open();

                        string query = @"
                        SELECT ID_usuario, Nom_usuario
                        FROM  Permisos
                        WHERE ID_permiso = @IDpermiso";

                        using (MySqlCommand comando = new MySqlCommand(query, cn))
                        {
                            comando.Parameters.AddWithValue("@IDpermiso", idpermiso);

                            using (MySqlDataReader reader = comando.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtIdUsr.Text = reader["ID_usuario"].ToString();
                                    txtNomUsuario.Text = reader["Nom_usuario"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró ningún empleado con el ID proporcionado.");
                                }
                            }
                        }
                        cn.Close();
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

        private void MENU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rol_Load(object sender, EventArgs e)
        {
            String consulta = "select * from Permisos";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
