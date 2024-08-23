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
    public partial class Empleados : Form
    {
        
        public Empleados()
        {
            InitializeComponent();
        }
        MySqlConnection cn = Conexion.getConexion();

        private void btGuardar_Click(object sender, EventArgs e)
        {

            if (//string.IsNullOrWhiteSpace(txtCod.Text) ||
                //string.IsNullOrWhiteSpace(txtCodUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtDepto.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text) ||
                string.IsNullOrWhiteSpace(txtPuesto.Text) ||
                cbbSexo.SelectedItem == null ||
                dtFecha.Value == null)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }
                try
                {
                //using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, cn))

                    string connectionString = "SELECT COUNT(*) FROM empleados WHERE id_usuario = @id";
                    using (MySqlCommand con = new MySqlCommand(connectionString, cn))
                    con.Parameters.AddWithValue("@id", txtCodUsuario.Text);
                    {

                    cn.Open();
                    string query = @"INSERT INTO empleados (id_usuario,Nombre,Apellido,Sexo,Telefono,Direccion,Email,Departamento, 
                    Fecha_ingreso,Salario,Puesto_trabajo)
                    VALUES (@id,@nombre,@apellido,@sexo,@telefono,@direccion,@email,@departamento,@fecha,@salario,@puesto)";

                    using (MySqlCommand comando = new MySqlCommand(query, cn))
                    {
                        comando.Parameters.AddWithValue("@id", txtCodUsuario.Text);
                        comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        comando.Parameters.AddWithValue("@apellido", txtApellido.Text);
                        comando.Parameters.AddWithValue("@sexo", cbbSexo.Text);
                        comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        comando.Parameters.AddWithValue("@email", txtEmail.Text);
                        comando.Parameters.AddWithValue("@departamento", txtDepto.Text);
                        comando.Parameters.AddWithValue("@fecha", dtFecha.Text);
                        comando.Parameters.AddWithValue("@salario", txtSalario.Text);
                        comando.Parameters.AddWithValue("@puesto", txtPuesto.Text);
                        comando.ExecuteNonQuery();
                    }
                    }


                    llamar_tablas();
                    limpiar_tablas();
                    cn.Close();
                    MessageBox.Show("Datos registrados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message);
                }

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE empleados SET Telefono = @telefono, Direccion = @direccion, Salario = @salario, Puesto_trabajo = @puesto WHERE ID_empleado = @id";

                MySqlCommand cmd = new MySqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@salario", txtSalario.Text);
                cmd.Parameters.AddWithValue("@puesto", txtPuesto.Text);
                cmd.Parameters.AddWithValue("@id", txtCod.Text);

                cn.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("¡Registro actualizado correctamente!");
                }
                else
                {
                    MessageBox.Show("No se encontró el empleado con el ID especificado.");
                }
                limpiar_tablas();
                llamar_tablas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");

                cn.Close();
            }

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            cn.Open();
            string id = txtCod.Text;
            String query = ("delete from empleados where ID_empleado = " + txtCod.Text);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Dato eliminado correctamente");
            llamar_tablas();
            limpiar_tablas();
            cn.Close();
        
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void limpiar_tablas()
        {
            txtCodUsuario.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cbbSexo.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtDepto.Text = "";
            dtFecha.Text = "";
            txtSalario.Text = "";
            txtPuesto.Text = "";
        }
        public void llamar_tablas()
        {
            String consulta = "select * from empleados";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Empleados_Load(object sender, EventArgs e)
        {
            String consulta = "select * from empleados";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void MENU_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void empleadosBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtCod.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtCodUsuario.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtNombre.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtApellido.Text = dataGridView1.SelectedCells[3].Value.ToString();
            cbbSexo.Text = dataGridView1.SelectedCells[4].Value.ToString();
            txtTelefono.Text = dataGridView1.SelectedCells[5].Value.ToString();
            txtDireccion.Text = dataGridView1.SelectedCells[6].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedCells[7].Value.ToString();
            txtDepto.Text = dataGridView1.SelectedCells[8].Value.ToString();
            dtFecha.Text = dataGridView1.SelectedCells[9].Value.ToString();
            txtSalario.Text = dataGridView1.SelectedCells[10].Value.ToString();
            txtPuesto.Text = dataGridView1.SelectedCells[11].Value.ToString();

        }
    }
    
        
}

//Shelly Ordoñez