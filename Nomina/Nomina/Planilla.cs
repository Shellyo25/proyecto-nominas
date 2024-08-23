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
using System.Web;
using MySql.Data;

namespace Nomina
{
    public partial class Planilla : Form
    {
        public Planilla()
        {
            InitializeComponent();

        }

        MySqlConnection cn = Conexion.getConexion();

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtcodE.Text, out int idEmpleado))
            {
                try
                {
                    using (MySqlConnection cn = Conexion.getConexion())
                    {
                        cn.Open();

                        string query = @"
                    SELECT
                        Nombre,
                        Apellido, 
                        Puesto_trabajo, 
                        Salario
                    FROM empleados 
                    WHERE ID_empleado = @IDEmpls";

                        using (MySqlCommand comando = new MySqlCommand(query, cn))
                        {
                            comando.Parameters.AddWithValue("@IDEmpls", idEmpleado);

                            using (MySqlDataReader reader = comando.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtNombre.Text = reader["Nombre"].ToString();
                                    txtApellido.Text = reader["Apellido"].ToString();
                                    txtPuesto.Text = reader["Puesto_trabajo"].ToString();
                                    txtSueldom.Text = reader["Salario"].ToString();

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
                    MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de empleado válido.");
            }
        }
        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId_salarios.Text, out int idSalario))
            {
                try
                {
                    using (MySqlConnection cn = Conexion.getConexion())
                    {
                        cn.Open();
                        string query = @"
                    SELECT
                        DiasLbrds, 
                        SlrioExtra, 
                        TtlDvngdo 
                    FROM Hrs_trabajadas
                    WHERE IDHrs = @IDHrs";

                        using (MySqlCommand comando = new MySqlCommand(query, cn))
                        {
                            comando.Parameters.AddWithValue("@IDHrs", idSalario);

                            using (MySqlDataReader reader2 = comando.ExecuteReader())
                            {
                                if (reader2.Read())
                                {
                                    // Asignar datos de la tabla empleados a textboxes
                                    txtDiasLab.Text = reader2["DiasLbrds"].ToString();
                                    txtSueldoe.Text = reader2["SlrioExtra"].ToString();
                                    txtTotal_dev.Text = reader2["TtlDvngdo"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró ningún calculo de salarios con el ID proporcionado.");
                                }
                            }
                        }
                        cn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }

        private void btnBuscar3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdDeduc.Text, out int idDeduccion))
            {
                try
                {
                    using (MySqlConnection cn = Conexion.getConexion())
                    {
                        cn.Open();
                        string query = @"
                    SELECT
                        Total_deducciones
                    FROM Deducciones
                    WHERE ID_deduccion = @ID_deduccion";

                        using (MySqlCommand comando = new MySqlCommand(query, cn))
                        {
                            comando.Parameters.AddWithValue("@ID_deduccion", idDeduccion);

                            using (MySqlDataReader reader3 = comando.ExecuteReader())
                            {
                                if (reader3.Read())
                                {
                                    // Asignar datos de la tabla empleados a textboxes
                                    txtTotal_des.Text = reader3["Total_deducciones"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró ninguna deduccion con el ID proporcionado.");
                                }
                            }
                        }
                        cn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcodE.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSueldom.Text) ||
                string.IsNullOrWhiteSpace(txtId_salarios.Text) ||
                string.IsNullOrWhiteSpace(txtDiasLab.Text) ||
                string.IsNullOrWhiteSpace(txtSueldoe.Text) ||
                string.IsNullOrWhiteSpace(txtTotal_dev.Text) ||
                string.IsNullOrWhiteSpace(txtIdDeduc.Text) ||
                string.IsNullOrWhiteSpace(txtTotal_des.Text) ||
                string.IsNullOrWhiteSpace(txtBoni.Text) ||
                string.IsNullOrWhiteSpace(txtSalariof.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }

            //string cadenaConexion = "server=192.168.1.250;port=3307;user id=proyecto;password=12345;database=nomina;";

            
            using (MySqlConnection cn = Conexion.getConexion())
            {
                try
                {
                    cn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Planilla WHERE ID_empleado = @IDEmpls AND IDHrs = @IDHrs AND Id_deduccion = @ID_deduccion";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, cn))
                    {
                        checkCommand.Parameters.AddWithValue("@IDEmpls", txtcodE.Text);
                        checkCommand.Parameters.AddWithValue("@IDHrs", txtId_salarios.Text);
                        checkCommand.Parameters.AddWithValue("@ID_deduccion", txtIdDeduc.Text);

                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Ya existe un registro con estos datos.");
                            return;
                        }
                    }

                    // Inserción de datos
                    string query = @"INSERT INTO Planilla (Fecha, ID_empleado, Nombre_emp, Apellido_emp, Puesto_emp, 
            IDHrs, DiasLab, SlrioMensual, SlrioExtra, TtlDvngdo, Id_deduccion, TtlDeduccion,Bonificacion,SlrioLiquido)
            VALUES (@Fecha, @IDEmpls, @Nombre_emp, @Apellido_emp, @Puesto_emp, 
            @IDHrs, @DiasLab, @SlrioMensual, @SlriExtra, @TtlDvngd, @Id_deduccion, @TtlDeduccion,@Boni, @SlrioLiquido)";

                    using (MySqlCommand comando = new MySqlCommand(query, cn))
                    {
                        comando.Parameters.AddWithValue("@Fecha", dtFecha.Text);
                        comando.Parameters.AddWithValue("@IDEmpls", txtcodE.Text);
                        comando.Parameters.AddWithValue("@Nombre_emp", txtNombre.Text);
                        comando.Parameters.AddWithValue("@Apellido_emp", txtApellido.Text);
                        comando.Parameters.AddWithValue("@Puesto_emp", txtPuesto.Text);
                        comando.Parameters.AddWithValue("@IDHrs", txtId_salarios.Text);
                        comando.Parameters.AddWithValue("@DiasLab", txtDiasLab.Text);
                        comando.Parameters.AddWithValue("@SlrioMensual", txtSueldom.Text);
                        comando.Parameters.AddWithValue("@SlriExtra", txtSueldoe.Text);
                        comando.Parameters.AddWithValue("@TtlDvngd", txtTotal_dev.Text);
                        comando.Parameters.AddWithValue("@Id_deduccion", txtIdDeduc.Text);
                        comando.Parameters.AddWithValue("@TtlDeduccion", txtTotal_des.Text);
                        comando.Parameters.AddWithValue("@Boni", txtBoni.Text);
                        comando.Parameters.AddWithValue("@SlrioLiquido", txtSalariof.Text);

                        comando.ExecuteNonQuery();
                    }

                    llamar_tablas();
                    LimpiarCampos();
                    MessageBox.Show("Datos registrados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message);
                }
                finally
                {
                    if (cn.State == System.Data.ConnectionState.Open)
                    {
                        cn.Close();
                    }
                }
            }
        }
        public void llamar_tablas()
        {
            String consulta = "SELECT * FROM Planilla";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void LimpiarCampos()
        {
            txtcodE.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtSueldom.Text = "";
            txtBoni.Text = "";
            txtId_salarios.Text = "";
            txtDiasLab.Text = "";
            txtSueldoe.Text = "";
            txtTotal_dev.Text = "";
            txtIdDeduc.Text = "";
            txtTotal_des.Text = "";
            txtSalariof.Text = "";
        }

        private void txtBoni_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDiasLab.Text, out decimal DiasLab))
            {
                //250/30= 8.333333333
                decimal Boni = DiasLab * 8.333333333m;
                txtBoni.Text = Boni.ToString("F2");

                CalcularSalarioTotal();
            }
            else
            {
                txtBoni.Text = "0.00";
            }
        }

        private void txtDiasLab_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDiasLab.Text, out decimal DiasLab))
            {
                //250/30= 8.333333333
                decimal Boni = DiasLab * 8.333333333m;
                txtBoni.Text = Boni.ToString("F2");

                CalcularSalarioTotal();
            }
            else
            {
                txtBoni.Text = "0.00";
            }

        }
        private void CalcularSalarioTotal()
        {
            if (decimal.TryParse(txtTotal_dev.Text, out decimal Dev) &&
                 decimal.TryParse(txtTotal_des.Text, out decimal Desc) &&
                 decimal.TryParse(txtBoni.Text, out decimal Boni))
            {
                decimal SueldoFinal = (Dev - Desc) + Boni;
                txtSalariof.Text = SueldoFinal.ToString("F2");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Planilla_Load(object sender, EventArgs e)
        {
                String consulta = "SELECT * FROM Planilla";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cn);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void MENU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void txtTotal_dev_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTotal_des_TextChanged(object sender, EventArgs e)
        {
           CalcularSalarioTotal();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtNombre.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtApellido.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtPuesto.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtSueldom.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtId_salarios.Text = dataGridView1.SelectedCells[4].Value.ToString();
            txtDiasLab.Text = dataGridView1.SelectedCells[5].Value.ToString();
            txtSueldoe.Text = dataGridView1.SelectedCells[6].Value.ToString();
            txtTotal_dev.Text = dataGridView1.SelectedCells[7].Value.ToString();
            txtIdDeduc.Text = dataGridView1.SelectedCells[8].Value.ToString();
            txtTotal_des.Text = dataGridView1.SelectedCells[9].Value.ToString();
            txtBoni.Text = dataGridView1.SelectedCells[10].Value.ToString();
            txtSalariof.Text = dataGridView1.SelectedCells[11].Value.ToString();
            txtcodE.Text = dataGridView1.SelectedCells[12].Value.ToString();
            dtFecha.Text = dataGridView1.SelectedCells[13].Value.ToString();
            txtCodPlanilla.Text = dataGridView1.SelectedCells[14].Value.ToString();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            cn.Open();
            string id = txtCodPlanilla.Text;
            String query = ("delete from Planilla where ID_planilla = " + txtCodPlanilla.Text);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Dato eliminado correctamente");
            llamar_tablas();
            LimpiarCampos();
            cn.Close();
        }
    }
}
